using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using OfficeOpenXml.ExternalReferences;
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

namespace AdminInversiones.Forms
{
    public partial class frm_Usuarios : Form
    {
        private ConexionBD conexion;
        private string plantillaHTML = Properties.Resources.plantilla_usuarios.ToString();
        private int idUsuario;
        private string nombreUsuario, status;
        double total = 0;
        Documentos docExcel = new Documentos();
        private List<Usuario> usuarios;
        public frm_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerUsuarios();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (idUsuario != 0 && status.Equals("ACTIVO"))
            {
                DialogResult result = MessageBox.Show($"Al dar de baja un usuario se generara un retiro con su saldo actual.\n" +
                                                     $"Esta seguro que quiere dar de baja al usuario:  {nombreUsuario}",
                                                    "Advertencia",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning,
                                                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    total = conexion.obtenerTotal(idUsuario);
                    conexion.actualizarDepositos(idUsuario);
                    conexion.generarRetiro(idUsuario, total);
                    conexion.actualizarTotal(idUsuario);
                    conexion.bajaUsuarios(idUsuario);
                    dataGridView1.DataSource = conexion.obtenerUsuarios();
                    MessageBox.Show($"Se dio de baja al usuario de manera correcta y se genero un retiro de  ${total} ","Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario valido primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idUsuario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["No. Socio"].Value.ToString());
                nombreUsuario = dataGridView1.Rows[e.RowIndex].Cells["Nombre de usuario"].Value.ToString();
                status = dataGridView1.Rows[e.RowIndex].Cells["ESTATUS"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Seleccione una fila no una columna", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ESTATUS"].Value.ToString().Equals("BAJA"))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnGenerarDoc_Click(object sender, EventArgs e)
        {
            tableToList();
            generarReporte();
            guardarDocumento();

        }

        public void tableToList()
        {
            usuarios = new List<Usuario>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var usuario = new Usuario();
                usuario.ID = int.Parse(row.Cells["No. Socio"].Value.ToString());
                usuario.Nombre = row.Cells["Nombre de usuario"].Value.ToString();
                usuario.Fecha_Registro = DateTime.Parse(row.Cells["Fecha de Registro"].Value.ToString()).ToString("dd-MM-yyyy");
                usuario.Cantidad_Ahorro = float.Parse(row.Cells["Total"].Value.ToString());
                usuario.Estatus = row.Cells["ESTATUS"].Value.ToString();
                usuarios.Add(usuario);
            }
        }//Fin tableToList()

        public void generarReporte()
        {

            //OBTENER LA FECHA INICIAL DONDE SE RECOGERAN LOS DATOS DE LA BD
            string fecha = DateTime.Now.ToString("MMMM-yyyy");

            string filas = string.Empty;
            int totalActivos = 0;
            int total = 0;
            foreach (Usuario user in usuarios)
            {
                if (user.Estatus.Equals("BAJA")) total++;
                else
                {
                    total++;
                    totalActivos++;
                }
                filas += "<tr>";
                filas += "<td>" + user.ID + "</td>";
                filas += "<td>" + user.Nombre + "</td>";
                filas += "<td>" + user.Fecha_Registro + "</td>";
                filas += "<td>" + user.Cantidad_Ahorro + "</td>";
                filas += "<td>" + user.Estatus +"</td>";
                filas += "</tr>";
                
            }
            plantillaHTML = Properties.Resources.plantilla_usuarios.ToString();
            plantillaHTML = plantillaHTML.Replace("@FECHA", fecha);
            plantillaHTML = plantillaHTML.Replace("@FILASUSUARIO", filas);
            plantillaHTML = plantillaHTML.Replace("@TOTALACT", totalActivos.ToString());
            plantillaHTML = plantillaHTML.Replace("@TOTAL",  total.ToString());

        }// Fin generarReporte

        public void guardarDocumento()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Archivos PDF(*.pdf)|*.pdf";
            savefile.FileName = string.Format("{0}.pdf", "Reporte Usuarios - " + DateTime.Now.ToString("MM-yyyy"));

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
                    MessageBox.Show("El archivo fue creado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                plantillaHTML = Properties.Resources.plantilla_usuarios.ToString();
            }
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            tableToList();
            docExcel.GuardarArchivoExcel(usuarios);
            
        }
    }
}
