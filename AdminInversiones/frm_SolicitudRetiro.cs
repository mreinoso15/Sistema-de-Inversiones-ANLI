using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    public partial class frm_SolicitudRetiro : Form
    {
        int idRetiro;
        ConexionBD conexion;
        public frm_SolicitudRetiro()
        {
            InitializeComponent();
        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Principal frmPrincipal = new frm_Principal();    
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void btn_Registros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudesRegistro frmRegistro = new frm_SolicitudesRegistro();
            frmRegistro.ShowDialog();
            this.Close();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Reportes frmReportes = new frm_Reportes();
            frmReportes.ShowDialog();
            this.Close();
        }

        private void btn_Deposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudDeposito frmDeposito = new frm_SolicitudDeposito();
            frmDeposito.ShowDialog();
            this.Close();
        }

        private void btn_Intereses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_IngresarInteres intereses = new frm_IngresarInteres();
            intereses.ShowDialog();
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void frm_SolicitudRetiro_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesRetiro();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRetiro = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID Retiro"].Value.ToString());
        }

        private void btn_Aprovar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.aceptarSolicitudRetiro(idRetiro);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido aceptada");
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }

        private void btn_Rechazar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.rechazarSolicitudRetiro(idRetiro);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido rechazada correctamente");

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }
    }
}
