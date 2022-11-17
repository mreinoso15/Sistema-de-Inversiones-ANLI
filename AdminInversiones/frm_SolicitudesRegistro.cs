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
        public frm_SolicitudesRegistro()
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

        private void btn_Retiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudRetiro frmRetiro = new frm_SolicitudRetiro();
            frmRetiro.ShowDialog();
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
