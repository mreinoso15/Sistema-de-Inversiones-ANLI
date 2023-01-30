using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    public partial class frm_Principal : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;


        public List<Inversiones> inversiones = null;
        List<double> listaIntereses = null;
        List<int> listaDias = null;
        ConexionBD conexionBD;
        Documentos documento;

        //Constructor
        public frm_Principal()
        {
            InitializeComponent();
            random = new Random();

        }

        //Eventos de Cambio de Pagina



        private void btn_CalculoInteres_Click(object sender, EventArgs e)
        {
            
            conexionBD = new ConexionBD();
            inversiones = conexionBD.obtenerInversiones(inversiones);
            MessageBox.Show(calcularInteres());
            crearReporteExcel();

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
                    double interes = (Math.Round(inversiones[i].Tasa,2) * diasInvertidos * Math.Round(inversiones[i].Cantidad,2))/360;
                    listaIntereses.Add(Math.Round(interes,2));
                    listaDias.Add(diasInvertidos);
                    
                   cad += "# de Socio: " + inversiones[i].NoSocio + " " + "\n" +
                           "Interes generado: " + Math.Round(interes,2) + "\n" + 
                           "Calculado a "+ diasInvertidos + " dias con una tasa de " + inversiones[i].Tasa + "\n\n";
                }
                return cad;
            }
            return "";
        }
        private void  crearReporteExcel()
        {
            documento = new Documentos();
            var file = new FileInfo(@"C:\Users\marti\Documents\Proyecto ANLI Inversiones\ReporteDeInversiones.xlsx");
            documento.GuardarArchivoExcel(inversiones,listaIntereses,listaDias, file);
            MessageBox.Show("Archivo creado exitosamente");
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


        //Metodos Cambio de colores en botones
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
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
                if (currentButton != (Button)btnSender) {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }//if2
            }//if1
        }//ActivateButton

        private void DisableButton() {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Snow;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }//if
            }
        }//DisableButton

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }


        private void btn_Registros_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Abrir Formulario de Solicitudes de Registros
            this.Hide();
            frm_SolicitudesRegistro frmSolicitudesRegistro = new frm_SolicitudesRegistro();
            frmSolicitudesRegistro.ShowDialog();
            this.Close();
        }//btn_Registros_Click

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Abrir Formulario de Creacion de Reportes
            this.Hide();
            frm_Reportes frmReportes = new frm_Reportes();
            frmReportes.ShowDialog();
            this.Close();
        }//btn_Reportes_Click

        private void btn_Depositos_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Abrir Formulario de Solicitudes de Deposito
            this.Hide();
            frm_SolicitudDeposito frmDeposito = new frm_SolicitudDeposito();
            frmDeposito.ShowDialog();
            this.Close();
        }//btn_Depositos_Click

        private void btn_Retiros_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Abrir Formulario de Solicitudes de Retiros
            this.Hide();
            frm_SolicitudRetiro frmSolicitudRetiro = new frm_SolicitudRetiro();
            frmSolicitudRetiro.ShowDialog();
            this.Close();
        }//btn_Retiros_Click

        private void btn_Interes_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Abrir Formulario de Ingreso de Interes 
        }//btn_Interes_Click

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Activar el color
            ActivateButton(sender);

            //Cerrar Sesion

        }//btn_Cerrar_Click


    }
}
