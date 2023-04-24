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
    public partial class frm_SolicitudesRegistro : Form
    {
        ConexionBD conexion;
        int idSolicitud;
        public frm_SolicitudesRegistro()
        {
            InitializeComponent();
        }

        private void frm_SolicitudesRegistro_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesRegistro();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSolicitud = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID SOLICITUD"].Value.ToString());
            
        }

        private void btn_AceptarSolicitud_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.aceptarSolicitudRegistro(idSolicitud);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido aceptada");

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }

        private void btn_RechazarSolicitud_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.rechazarSolicitudRegistro(idSolicitud);
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
