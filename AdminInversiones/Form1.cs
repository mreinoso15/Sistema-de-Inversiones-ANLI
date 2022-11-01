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
    public partial class Form1 : Form
    {
        //VARIABLES GLOBALES
        bool estadoMenu = true;

        public Form1()
        {
            InitializeComponent();
            //PLOTEO DE LA GRAFICA
            cht_desgloseSolicitudes.Titles.Add("Desglose solicitudes");
            cht_desgloseSolicitudes.Series["s1"].IsValueShownAsLabel = true;
            cht_desgloseSolicitudes.Series["s1"].Points.AddXY("Aceptadas", "25");
            cht_desgloseSolicitudes.Series["s1"].Points.AddXY("Denegadas", "25");
            cht_desgloseSolicitudes.Series["s1"].Points.AddXY("Pendientes", "50");
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            //SE HABILITA EL MENU DESPLEGABLE
            if (estadoMenu)
            {
                btn_Reportes.Visible = true;
                btn_solicitudInversion.Visible = true;
                btn_solicitudRegistro.Visible = true;
                estadoMenu = false;
            }
            else
            {
                btn_Reportes.Visible = false;
                btn_solicitudInversion.Visible = false;
                btn_solicitudRegistro.Visible = false;
                estadoMenu= true;
            }
             
        }
    }
}
