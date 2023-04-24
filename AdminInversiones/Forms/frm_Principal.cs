using AdminInversiones.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdminInversiones
{
    public partial class frm_Principal : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public List<Inversiones> inversiones = null;
        List<double> listaIntereses = null;
        List<int> listaDias = null;
        ConexionBD conexionBD;
        Documentos documento;
        //Constructor

        public frm_Principal()
        {
            InitializeComponent();
            customizeDesign();
            random = new Random();
        }
        
        //EVENTOS CLICK

        private void btn_Registros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SolicitudesRegistro(), sender);
            lblTitleBar.Text = "Solicitudes de registro de usuario";
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Reportes(), sender);
            lblTitleBar.Text = "Generacion de reportes";
        }

        private void btn_Depositos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SolicitudDeposito(), sender);
            lblTitleBar.Text = "Solicitudes de deposito en efectivo";
        }

        private void btn_Retiros_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SolicitudRetiro(), sender);
            lblTitleBar.Text = "Solicitudes de retiro";
        }

        private void btn_Interes_Click_1(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_IngresarInteres(), sender);
            showSubMenu(pnlSubMenu);
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login frmLogin = new frm_Login();
            frmLogin.ShowDialog();
            this.Close();
            //Cerrar Sesion
        }
        private void btnActulizarInteres_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frm_IngresarInteres(), sender);
            lblTitleBar.Text = "Modificacion de intereses";
        }
        private void btnCalcularIntereses_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            conexionBD = new ConexionBD();
            

        }

        //Metodos Diseno

        private void customizeDesign()
        {
            pnlSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if(pnlSubMenu.Visible == true) pnlSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true; 
            }
            else subMenu.Visible = false;   
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }//while
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }//SelectThemeColor

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                DisableButtonSubMenu();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }//if2
            }//if1
        }//ActivateButton
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Snow;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }//if
            }
        }//DisableButton
        private void DisableButtonSubMenu()
        {
            foreach (Control previousBtn in pnlSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 32, 39);
                    previousBtn.ForeColor = Color.Snow;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }//if
            }
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //Funciones
        private void codigoBoton()
        {
            conexionBD = new ConexionBD();
            inversiones = conexionBD.obtenerInversiones(inversiones);
            MessageBox.Show(calcularInteres());
            crearReporteExcel();
            actualizarIntereses();
        }
        private string calcularInteres()
        {
            string cad = "";
            listaDias = new List<int>();
            listaIntereses = new List<double>();
            if (inversiones == null) MessageBox.Show("No hay inversiones a calcular");
            else
            {
                for (int i = 0; i < inversiones.Count; i++)
                {
                    int diasInvertidos = (DateTime.Now - inversiones[i].Fecha).Days;
                    double interes = (Math.Round(inversiones[i].Tasa, 2) * diasInvertidos * Math.Round(inversiones[i].Cantidad, 2)) / 360;
                    listaIntereses.Add(Math.Round(interes, 2));
                    listaDias.Add(diasInvertidos);

                    cad += "# de Socio: " + inversiones[i].NoSocio + " " + "\n" +
                            "Interes generado: " + Math.Round(interes, 2) + "\n" +
                            "Calculado a " + diasInvertidos + " dias con una tasa de " + inversiones[i].Tasa + "\n\n";
                }
                return cad;
            }
            return "";
        }
        private void crearReporteExcel()
        {
            documento = new Documentos();
            var file = new FileInfo(@"C:\Users\marti\Documents\Proyecto ANLI Inversiones\ReporteDeInversiones.xlsx");
            documento.GuardarArchivoExcel(inversiones, listaIntereses, listaDias, file);
            MessageBox.Show("Archivo creado exitosamente");
        }
        private void actualizarIntereses()
        {
            for (int i = 0; i < inversiones.Count; i++)
            {
                conexionBD.actualizarInteresGenerado(inversiones[i].NoSocio, listaIntereses[i]);
            }
        }
        private void mostrarInversiones()
        {
            string cad = "";
            for (int i = 0; i < inversiones.Count; i++)
            {
                cad += "# de Socio: " + inversiones[i].NoSocio + " " + "\n" +
                       "ID del Deposito: " + inversiones[i].solicitudInv + "\n" +
                       "Nombre Usuario: " + inversiones[i].Socio + "\n" +
                       "Fecha: " + inversiones[i].Fecha + " " + "\n" +
                       "Cantidad Invertida: " + inversiones[i].Cantidad + " " + "\n" +
                       "Tasa de Interes: " + inversiones[i].Tasa + "\n\n";

            }

        }

        
    }
}
