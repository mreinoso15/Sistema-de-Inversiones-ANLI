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
    public partial class frm_Reportes : Form
    {
        public frm_Reportes()
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
            frm_SolicitudesRegistro frmRegistros = new frm_SolicitudesRegistro();
            frmRegistros.ShowDialog();
            this.Close();
        }

        private void btn_Depositos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudDeposito frmDepositos = new frm_SolicitudDeposito();
            frmDepositos.ShowDialog();
            this.Close();
        }

        private void btn_Retiros_Click(object sender, EventArgs e)
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
    }
}
