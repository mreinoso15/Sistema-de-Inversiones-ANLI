using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminInversiones.Forms
{
    public partial class frm_CalcularImpuestos : Form
    {
        private ConexionBD conexion;
        private List<Impuestos> impuestos;
        private string plantillaHTML = Properties.Resources.plantilla_impuestos.ToString();
        private List<Impuestos> nuevaListaImpuestos;

        public frm_CalcularImpuestos()
        {
            InitializeComponent();
        }

        private void frm_CalcularImpuestos_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            SetMyCustomFormat();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFechaImpuestos.Format = DateTimePickerFormat.Custom;
            dtpFechaImpuestos.CustomFormat = "MM/yyyy";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaImpuestos = dtpFechaImpuestos.Value.Year.ToString() + "-" +
                          dtpFechaImpuestos.Value.Month.ToString() + "-" +
                          dtpFechaImpuestos.Value.Day.ToString();
            impuestos = conexion.obtenerTablaImpuestos(impuestos, fechaImpuestos);
            if(impuestos?.Any() != true)
            {
                MessageBox.Show("No se encontraron datos para este mes.",
                                "Impuestos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                var bindingList = new BindingList<Impuestos>(calcularImpuestos(impuestos));
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                txtTotal.Text = "$ " + Math.Round(conexion.calcularTotalImpuestos(fechaImpuestos), 2) + "";
                btnGenerarDoc.Enabled = true;
            }
        }

        public List<Impuestos> calcularImpuestos(List<Impuestos> total)
        {
            nuevaListaImpuestos = new List<Impuestos>();
            
            for (int i = 0; i < total.Count; i++)
            {
                if(i > 0)
                {
                    Impuestos nuevo = total[i];
                    if (nuevo.Nombre != nuevaListaImpuestos.Last<Impuestos>().Nombre)
                    {
                        
                        nuevaListaImpuestos.Add(nuevo);
                    }
                    else
                    {
                        nuevaListaImpuestos.Last<Impuestos>().Cantidad += nuevo.Cantidad;
                    }
                }
                else
                {
                    
                    nuevaListaImpuestos.Add(total[i]);
                }
                
            }
            return nuevaListaImpuestos;
        }

        private void btnGenerarDoc_Click(object sender, EventArgs e)
        {
            generarReporte();
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
                    var document = HtmlConverter.ConvertToDocument(plantillaHTML, pdf, converterProperties);
                    document.SetMargins(25, 25, 25, 25);
                    document.Close();
                    stream.Close();
                }
                plantillaHTML = Properties.Resources.plantilla_impuestos.ToString();
            }
        }

        public void generarReporte()
        {
            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fechaImpuestos = dtpFechaImpuestos.Value.ToString("MMMM-yyyy");


            if (nuevaListaImpuestos?.Any() == true)
            {
                string filas = string.Empty;
                double total = 0;

                foreach (Impuestos i in nuevaListaImpuestos)
                {
                    filas += "<tr>";
                    filas += "<td>" + i.Id + "</td>";
                    filas += "<td>" + i.Nombre + "</td>";
                    filas += "<td>" + i.Fecha.ToString("dd-MM-yyyy") + "</td>";
                    filas += "<td>" +"$ "+ i.Cantidad + "</td>";
                    filas += "</tr>";
                    total += i.Cantidad;
                }
                plantillaHTML = Properties.Resources.plantilla_impuestos.ToString();
                plantillaHTML = plantillaHTML.Replace("@FECHA", fechaImpuestos);
                plantillaHTML = plantillaHTML.Replace("@FILASIMPUESTO", filas);
                plantillaHTML = plantillaHTML.Replace("@TOTAL", "$ "+ total.ToString());

            }
            else
            {
                MessageBox.Show("No hay datos en ese rango de fechas");
            }
        }
    }
}
