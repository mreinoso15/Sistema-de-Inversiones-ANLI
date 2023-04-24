using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iText;
using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using MySqlX.XDevAPI.Relational;
using static System.Net.WebRequestMethods;

namespace AdminInversiones
{
    public partial class frm_Reportes : Form
    {
        ConexionBD conexion;
        private List<Retiros> retiro = new List<Retiros>();
        private string plantillaHTML = Properties.Resources.plantilla.ToString();
        public frm_Reportes()
        {
            InitializeComponent();
        }

        private void frm_Reportes_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            cmb_Socios = conexion.obtenerNoSocio(cmb_Socios);
        }

        private void btn_PDFSocio_Click(object sender, EventArgs e)
        {
            generarReporte();
            
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", cmb_Socios.SelectedValue.ToString() + " " + DateTime.Now.ToString("dd-MM-yyyy"));

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdf = new PdfDocument(writer);
                    pdf.SetDefaultPageSize(PageSize.A4);
                    var document = HtmlConverter.ConvertToDocument(plantillaHTML, pdf, converterProperties);
                    document.SetMargins(25, 25, 25, 25);
                    document.Close();
                    stream.Close();
                }
                plantillaHTML = Properties.Resources.plantilla.ToString();
            }
        }
        public void generarReporte()
        {
            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaInicio = date_InicioReporteSocio.Value.Year.ToString() + "-" +
                          date_InicioReporteSocio.Value.Month.ToString() + "-" +
                          date_InicioReporteSocio.Value.Day.ToString();

            //OBTENER LA FECHA FINAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaFinal = date_FinReporteSocio.Value.Year.ToString() + "-" +
                                date_FinReporteSocio.Value.Month.ToString() + "-" +
                                date_FinReporteSocio.Value.Day.ToString();

            //OBTENER EL USUARIO EL CUAL QUIERE SOLICITAR EL REPORTE
            int idusuario = Int32.Parse(cmb_Socios.SelectedValue.ToString());

            //SE OBTIENEN LOS DATOS NECESARIOS PARA GENERAR EL REPORTE
            retiro = conexion.obtenerDataReportes(retiro,fechaInicio,fechaFinal,idusuario);

            if(retiro != null)
            {
                string filas = string.Empty;
                decimal total = 0;

                foreach (Retiros r in retiro)
                {
                    filas += "<tr>";
                    filas += "<td>" + r.IdDeposito + "</td>";
                    filas += "<td>" + "Retiro sin calculo de interes" + "</td>";
                    filas += "<td>" + r.FechaAprob.ToString("dd-MMMM-yyyy") + "</td>";
                    filas += "<td>" + r.Cantidad + "</td>";
                    filas += "</tr>";
                    total += (decimal)r.Cantidad;
                }
                plantillaHTML = Properties.Resources.plantilla.ToString();
                plantillaHTML = plantillaHTML.Replace("@CLIENTE", retiro[0].Nombre);
                plantillaHTML = plantillaHTML.Replace("@USERID", retiro[0].IdUsuario+"");
                plantillaHTML = plantillaHTML.Replace("@FECHA", DateTime.Now.ToString("dd/MMMM/yyyy"));
                plantillaHTML = plantillaHTML.Replace("@FILASRETIRO", filas);
                plantillaHTML = plantillaHTML.Replace("@TOTAL", total.ToString());

            }
            else
            {
                MessageBox.Show("No hay datos en ese rango de fechas");
            }
        }

    }
}
