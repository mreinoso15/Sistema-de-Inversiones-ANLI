using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    public partial class frm_SolicitudDeposito : Form
    {
        private int idDeposito, idUsuario; 
        private string URLS;
        
        ConexionBD conexion;
        public frm_SolicitudDeposito()
        {
            InitializeComponent();
            
        }

        private void frm_SolicitudDeposito_Load(object sender, EventArgs e)
        {
            //LLENAR LA TABLA CON LOS VALORES DE LA BASE DE DATOS
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesDeposito();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Selected == true && txtFolio.Text != "")
            {
                conexion.aceptarSolicitudDeposito(idDeposito, txtFolio.Text);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido aceptada","Depositos",MessageBoxButtons.OK,MessageBoxIcon.Information);  
                
                txtFolio.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila y verificar que el folio fue ingresado");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDeposito = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID Solicitud"].Value.ToString());
            idUsuario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["No.Socio"].Value.ToString());
            URLS = dataGridView1.Rows[e.RowIndex].Cells["Foto URL"].Value.ToString();
            try
            {
                System.Diagnostics.Process.Start(URLS);
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("No hay URL para abrir");
            }
            
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
