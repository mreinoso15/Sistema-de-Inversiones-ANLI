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
    public partial class frm_SolicitudDeposito : Form
    {
        int idDeposito;
        ConexionBD conexion;
        public frm_SolicitudDeposito()
        {
            InitializeComponent();
            
        }
        //Cambio entre formularios
        private void btn_Principal_Click(object sender, EventArgs e)
        {
            //Ir al Formulario Principal
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

        private void btn_Retiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudRetiro frmRetiros = new frm_SolicitudRetiro();
            frmRetiros.ShowDialog();
            this.Close();
        }

        private void btn_Intereses_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void frm_SolicitudDeposito_Load(object sender, EventArgs e)
        {
            //LLENAR LA TABLA CON LOS VALORES DE LA BASE DE DATOS
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesDeposito();
            
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Selected == true)
            {
                conexion.aceptarSolicitudDeposito(idDeposito);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido aceptada");
                
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDeposito = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID Deposito"].Value.ToString());
        }

        private void btn_Rechazar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.rechazarSolicitudDeposito(idDeposito);
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
