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
    public partial class frm_Principal : Form
    {
      
        public frm_Principal()
        {
            InitializeComponent();
            
        }
        //Eventos de Cambio de Pagina
        private void btn_Registros_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Solicitudes de Registros
            this.Hide();
            frm_SolicitudesRegistro frmSolicitudesRegistro = new frm_SolicitudesRegistro();
            frmSolicitudesRegistro.ShowDialog();
            this.Close();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Creacion de Reportes
            this.Hide();
            frm_Reportes frmReportes = new frm_Reportes();
            frmReportes.ShowDialog();
            this.Close();
        }

        private void btn_Depositos_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Solicitudes de Deposito
            this.Hide();
            frm_SolicitudDeposito frmDeposito = new frm_SolicitudDeposito();
            frmDeposito.ShowDialog();
            this.Close();
        }

        private void btn_Retiros_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Solicitudes de Retiros
            this.Hide();
            frm_SolicitudRetiro frmSolicitudRetiro = new frm_SolicitudRetiro();
            frmSolicitudRetiro.ShowDialog();
            this.Close();
        }

        private void btn_Interes_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Ingreso de Interes 
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Cerrar Sesion
        }
    }
}
