using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText;
using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;

namespace AdminInversiones
{
    public partial class frm_Reportes : Form
    {
        ConexionBD conexion;
        private List<Impuestos> impuestos = new List<Impuestos>();
        private List<Depositos> deposito = new List<Depositos>();
        private List<DepositosCalculados> depositoCalc = new List<DepositosCalculados>();
        private List<Retiros> retiro = new List<Retiros>();
        private string plantillaHTMLUSER = Properties.Resources.plantilla.ToString();
        private string plantillaHTMLGRAL = Properties.Resources.plantilla_general.ToString();
        private string plantillaHTMLImpuestos = Properties.Resources.plantilla_impuestos_usuario.ToString();
        public frm_Reportes()
        {
            InitializeComponent();
        }

        private void frm_Reportes_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            cmb_Socios = conexion.obtenerNoSocio(cmb_Socios);
            cmbSociosImpuestos = conexion.obtenerNoSocio(cmbSociosImpuestos);
            SetMyCustomFormat();
        }
        private void btn_PDFSocio_Click(object sender, EventArgs e)
        {
            generarReporte(Int32.Parse(cmb_Socios.SelectedValue.ToString()));
            
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Archivos PDF(*.pdf)|*.pdf";
            savefile.FileName = string.Format("{0}.pdf", "Estado de cuenta - Usuario # "+cmb_Socios.SelectedValue.ToString() + " " + DateTime.Now.ToString("dd-MM-yyyy"));

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdf = new PdfDocument(writer);
                    pdf.SetDefaultPageSize(PageSize.A4);
                    var document = HtmlConverter.ConvertToDocument(plantillaHTMLUSER, pdf, converterProperties);
                    document.SetMargins(25, 25, 25, 25);
                    document.Close();
                    stream.Close();
                    MessageBox.Show("El archivo fue creado correctamente", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                plantillaHTMLUSER = Properties.Resources.plantilla.ToString();
            }
        }
        public void generarReporte(int idusuario)
        {
            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaInicio = date_InicioReporteSocio.Value.Year.ToString() + "-" +
                          date_InicioReporteSocio.Value.Month.ToString() + "-" +
                          date_InicioReporteSocio.Value.Day.ToString();

            //OBTENER LA FECHA FINAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaFinal = date_FinReporteSocio.Value.Year.ToString() + "-" +
                                date_FinReporteSocio.Value.Month.ToString() + "-" +
                                date_FinReporteSocio.Value.Day.ToString();           

            //SE OBTIENEN LOS DATOS NECESARIOS PARA GENERAR EL REPORTE
            //SE OBTIENEN LOS RETIROS
            deposito = conexion.obtenerDataReportes(deposito,fechaInicio,fechaFinal,idusuario);
            retiro = conexion.obtenerDataReportes(retiro, fechaInicio, fechaFinal, idusuario);
            depositoCalc = conexion.obtenerDataReportes(depositoCalc, fechaInicio, fechaFinal, idusuario);

            if(deposito != null || depositoCalc != null || retiro != null)
            {
                string filas = string.Empty;
                decimal totalMes = 0;
                float total = (float)conexion.obtenerTotal(idusuario);
                if(deposito != null)
                {
                    foreach (Depositos d in deposito)
                    {
                        filas += "<tr>";
                        filas += "<td>" + d.IdDeposito + "</td>";
                        filas += "<td>" + "Deposito" + "</td>";
                        filas += "<td>" + DateTime.Parse(d.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)d.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMes += (decimal)d.Cantidad;
                    }
                }
                if(depositoCalc != null)
                {
                    foreach(DepositosCalculados dc in depositoCalc)
                    {
                        filas += "<tr>";
                        filas += "<td>" + dc.IdDeposito + "</td>";
                        filas += "<td>" + "Depositos con interes calculado" + "</td>";
                        filas += "<td>" + DateTime.Parse(dc.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)dc.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMes += (decimal)dc.Cantidad;
                    }
                }
                if(retiro != null)
                {
                    foreach(Retiros r in retiro)
                    {
                        filas += "<tr>";
                        filas += "<td>" + r.IdRetiro + "</td>";
                        filas += "<td>" + "Retiro" + "</td>";
                        filas += "<td>" + DateTime.Parse(r.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)r.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMes -= (decimal)r.Cantidad;
                    }
                }
                
                plantillaHTMLUSER = Properties.Resources.plantilla.ToString();
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@CLIENTE", conexion.obtenerNombre(idusuario));
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@USERID", idusuario+"");
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@FECHA", DateTime.Now.ToString("dd/MMMM/yyyy"));
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@FILASRETIRO", filas);
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@TOTALMES", Math.Round(totalMes,2).ToString());
                plantillaHTMLUSER = plantillaHTMLUSER.Replace("@TOTAL", total+"");

            }
            else
            {
                MessageBox.Show("No hay datos en ese rango de fechas");
            }
        }

        private void btn_ExcelSocio_Click(object sender, EventArgs e)
        {
            Documentos docExcel = new Documentos();
            //OBTENER IDUSUARIO
            var idusuario = Int32.Parse(cmb_Socios.SelectedValue.ToString());
            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaInicio = date_InicioReporteSocio.Value.Year.ToString() + "-" +
                          date_InicioReporteSocio.Value.Month.ToString() + "-" +
                          date_InicioReporteSocio.Value.Day.ToString();

            //OBTENER LA FECHA FINAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaFinal = date_FinReporteSocio.Value.Year.ToString() + "-" +
                                date_FinReporteSocio.Value.Month.ToString() + "-" +
                                date_FinReporteSocio.Value.Day.ToString();

            //SE OBTIENEN LOS DATOS NECESARIOS PARA GENERAR EL REPORTE
            //SE OBTIENEN LOS RETIROS
            deposito = conexion.obtenerDataReportes(deposito, fechaInicio, fechaFinal, idusuario);
            retiro = conexion.obtenerDataReportes(retiro, fechaInicio, fechaFinal, idusuario);
            depositoCalc = conexion.obtenerDataReportes(depositoCalc, fechaInicio, fechaFinal, idusuario);

            docExcel.GuardarArchivoExcel(deposito, depositoCalc, retiro);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_PDFecha_Click(object sender, EventArgs e)
        {
            generarReporte();

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Archivos PDF(*.pdf)|*.pdf";
            savefile.FileName = string.Format("{0}.pdf", "Estado de cuenta - MENSUAL " + DateTime.Now.ToString("dd-MM-yyyy"));

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdf = new PdfDocument(writer);
                    pdf.SetDefaultPageSize(PageSize.A4);
                    var document = HtmlConverter.ConvertToDocument(plantillaHTMLGRAL, pdf, converterProperties);
                    document.SetMargins(25, 25, 25, 25);
                    document.Close();
                    stream.Close();
                    MessageBox.Show("El archivo fue creado correctamente", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                plantillaHTMLGRAL = Properties.Resources.plantilla_general.ToString();
            }
        }

        private void generarReporte()
        {

            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaInicio = date_InicioReporteFecha.Value.Year.ToString() + "-" +
                          date_InicioReporteFecha.Value.Month.ToString() + "-" +
                          date_InicioReporteFecha.Value.Day.ToString();

            //OBTENER LA FECHA FINAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaFinal = date_FinReporteFecha.Value.Year.ToString() + "-" +
                                date_FinReporteFecha.Value.Month.ToString() + "-" +
                                date_FinReporteFecha.Value.Day.ToString();

            //SE OBTIENEN LOS DATOS NECESARIOS PARA GENERAR EL REPORTE
            //SE OBTIENEN LOS RETIROS
            deposito = conexion.obtenerDataReportes(deposito, fechaInicio, fechaFinal);
            retiro = conexion.obtenerDataReportes(retiro, fechaInicio, fechaFinal);
            depositoCalc = conexion.obtenerDataReportes(depositoCalc, fechaInicio, fechaFinal);

            if (deposito != null || depositoCalc != null || retiro != null)
            {
                string filas = string.Empty;
                decimal totalMes = 0;
                decimal totalMesR = 0;

                if (deposito != null)
                {
                    foreach (Depositos d in deposito)
                    {
                        filas += "<tr>";
                        filas += "<td>" + d.Nombre + "</td>";
                        filas += "<td>" + d.IdDeposito + "</td>";
                        filas += "<td>" + "Deposito" + "</td>";
                        filas += "<td>" + DateTime.Parse(d.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)d.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMes += (decimal)d.Cantidad;
                    }
                }
                if (depositoCalc != null)
                {
                    foreach (DepositosCalculados dc in depositoCalc)
                    {
                        filas += "<tr>";
                        filas += "<td>" + dc.Nombre + "</td>";
                        filas += "<td>" + dc.IdDeposito + "</td>";
                        filas += "<td>" + "Depositos con interes calculado" + "</td>";
                        filas += "<td>" + DateTime.Parse(dc.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)dc.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMes += (decimal)dc.Cantidad;
                    }
                }
                if (retiro != null)
                {
                    foreach (Retiros r in retiro)
                    {
                        filas += "<tr>";
                        filas += "<td>" + r.Nombre + "</td>";
                        filas += "<td>" + r.IdRetiro + "</td>";
                        filas += "<td>" + "Retiro" + "</td>";
                        filas += "<td>" + DateTime.Parse(r.FechaAprob).ToString("dd-MMMM-yyyy") + "</td>";
                        filas += "<td>" + (float)r.Cantidad + "</td>";
                        filas += "</tr>";
                        totalMesR += (decimal)r.Cantidad;
                    }
                }

                plantillaHTMLGRAL = Properties.Resources.plantilla_general.ToString();
                plantillaHTMLGRAL = plantillaHTMLGRAL.Replace("@FECHA", DateTime.Now.ToString("dd/MMMM/yyyy"));
                plantillaHTMLGRAL = plantillaHTMLGRAL.Replace("@FILASRETIRO", filas);
                plantillaHTMLGRAL = plantillaHTMLGRAL.Replace("@TOTALMES", Math.Round(totalMes, 2).ToString());
                plantillaHTMLGRAL = plantillaHTMLGRAL.Replace("@TOTALRETIRO", Math.Round(totalMesR, 2).ToString() + "");

            }
            else
            {
                MessageBox.Show("No hay datos en ese rango de fechas");
            }
        }

        private void btn_ExcelFecha_Click(object sender, EventArgs e)
        {
            Documentos docExcel = new Documentos();
            //OBTENER IDUSUARIO
            var idusuario = Int32.Parse(cmb_Socios.SelectedValue.ToString());
            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaInicio = date_InicioReporteSocio.Value.Year.ToString() + "-" +
                          date_InicioReporteSocio.Value.Month.ToString() + "-" +
                          date_InicioReporteSocio.Value.Day.ToString();

            //OBTENER LA FECHA FINAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaFinal = date_FinReporteSocio.Value.Year.ToString() + "-" +
                                date_FinReporteSocio.Value.Month.ToString() + "-" +
                                date_FinReporteSocio.Value.Day.ToString();

            //SE OBTIENEN LOS DATOS NECESARIOS PARA GENERAR EL REPORTE
            //SE OBTIENEN LOS RETIROS
            deposito = conexion.obtenerDataReportes(deposito, fechaInicio, fechaFinal);
            retiro = conexion.obtenerDataReportes(retiro, fechaInicio, fechaFinal);
            depositoCalc = conexion.obtenerDataReportes(depositoCalc, fechaInicio, fechaFinal);

            docExcel.GuardarArchivoExcel(deposito, depositoCalc, retiro);
        }

        private void btnPDFImpuestos_Click(object sender, EventArgs e)
        {
            generarReporteImpuestos(Int32.Parse(cmbSociosImpuestos.SelectedValue.ToString()));
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Archivos PDF(*.pdf)|*.pdf";
            savefile.FileName = string.Format("{0}.pdf", "Reporte impuestos - " + dtpFechaImpuestos.Value.ToString("MM-yyyy"));

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdf = new PdfDocument(writer);
                    pdf.SetDefaultPageSize(PageSize.A4);
                    var document = HtmlConverter.ConvertToDocument(plantillaHTMLImpuestos, pdf, converterProperties);
                    document.SetMargins(25, 25, 25, 25);
                    document.Close();
                    stream.Close();
                }
                plantillaHTMLImpuestos = Properties.Resources.plantilla_impuestos.ToString();
            }
        }

        private void generarReporteImpuestos(int idusuario)
        {
            string fechaInicio = dtpFechaImpuestos.Value.Year.ToString() + "-" +
                          dtpFechaImpuestos.Value.Month.ToString() + "-" +"01";

            string fechaFinal = dtpFechaImpuestos.Value.Year.ToString() + "-" +
                          dtpFechaImpuestos.Value.Month.ToString() + "-" + 
                          DateTime.DaysInMonth(dtpFechaImpuestos.Value.Year, dtpFechaImpuestos.Value.Month); ;

            impuestos = conexion.obtenerTablaImpuestos(impuestos,idusuario, fechaInicio, fechaFinal);

           if(impuestos.Any() == true)
            {
                string filas = string.Empty;
                double total = 0;

                foreach (Impuestos i in impuestos)
                {
                    filas += "<tr>";
                    filas += "<td>" + i.Id + "</td>";
                    filas += "<td>" + i.Nombre + "</td>";
                    filas += "<td>" + i.Fecha.ToString("dd-MM-yyyy") + "</td>";
                    filas += "<td>" + "$ " + i.Cantidad + "</td>";
                    filas += "</tr>";
                    total += i.Cantidad;
                }

                plantillaHTMLImpuestos = plantillaHTMLImpuestos.Replace("@FECHA",DateTime.Parse(fechaInicio).ToString("dd-MMMM-yyyy") + " - " + DateTime.Parse(fechaFinal).ToString("dd-MMMM-yyyy"));
                plantillaHTMLImpuestos = plantillaHTMLImpuestos.Replace("@FILASIMPUESTO", filas);
                plantillaHTMLImpuestos = plantillaHTMLImpuestos.Replace("@TOTAL", "$ " + total.ToString());
            }
            else
            {
                MessageBox.Show("No hay datos en ese rango de fechas",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
                

        
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFechaImpuestos.Format = DateTimePickerFormat.Custom;
            dtpFechaImpuestos.CustomFormat = "MM/yyyy";
            dtpFechaImpuestos.ShowUpDown = true;
        }
    }
}
