using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones.Forms
{
    public partial class frm_Login : Form
    {
        private ConexionBD conexionBD;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conexionBD = new ConexionBD();  
            if(conexionBD.verificarLogin(txtUser.Text,txtPassword.Text) == true)
            {
                this.Hide();
                frm_Principal frmMain = new frm_Principal();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
