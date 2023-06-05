using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace AdminInversiones
{
    

    public partial class frm_IngresarInteres : Form
    {
        ConexionBD conexion;
        List<HistorialTasas> tasas;
        Documentos docExcel = new Documentos();
        public frm_IngresarInteres()
        {
            InitializeComponent();
        }

        private void frm_IngresarInteres_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerHistorialTasas();
            cmb_tasas = conexion.obtenerTasasInversiones(cmb_tasas);
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void btn_ingresarTasa_Click(object sender, EventArgs e)
        {
            if (validarCampos() == false) MessageBox.Show("Faltan datos por llenar, revisa de nuevo los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else {
                double tasa = Double.Parse(txt_valorTasa.Value.ToString());
                string tipo = txt_tipoTasa.Text;
                string descripcion = txt_descripcion.Text;
                conexion.insertarTasaInteres(tasa, tipo, descripcion);
                MessageBox.Show("Los datos fueron insertados","Intereses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiarCamposInsertar();
                cmb_tasas = conexion.obtenerTasasInversiones(cmb_tasas);
            };
        }

        public Boolean validarCampos()
        {
            if (!string.IsNullOrEmpty(txt_tipoTasa.Text) && !string.IsNullOrEmpty(txt_descripcion.Text)) return true;
            return false;
            
        }
        public void limpiarCamposInsertar()
        {
            txt_valorTasa.Value = Decimal.Parse(0.00+"");
            txt_tipoTasa.Text = "";
            txt_descripcion.Text = "";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"La nueva tasa sera: \n {txt_valorActualizar.Value} \n Esta seguro?",
                                                    "Advertencia",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning,
                                                    MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    conexion.actualizarTasa(Int32.Parse(cmb_tasas.SelectedValue + ""), (double)txt_valorActualizar.Value);
                    MessageBox.Show("La tasa fue modificada correctamente","Actualizar interes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                case DialogResult.No:
                    return;

            } 

            //MessageBox.Show(cmb_tasas.SelectedValue+"");
        }

        private void btn_ActualizarImpuesto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"El nuevo impuesto sera sera: \n {txtActualizarImpuestos.Value} \n Esta seguro?",
                                                    "Advertencia",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning,
                                                    MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    conexion.actualizarImpuestos((double)txtActualizarImpuestos.Value);
                    MessageBox.Show("El impuesto fue modificado correctamente", "Actualizar impuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarImpuestos.Value = (decimal)0.00;
                    break;

                case DialogResult.No:
                    return;

            }

        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                tableToList();
                docExcel.GuardarArchivoExcel(tasas);
            }
            else
            {
                MessageBox.Show("No hay datos para generar el documento","Historial tasa de interes",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void tableToList()
        {
            tasas = new List<HistorialTasas>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var tasa = new HistorialTasas();
                tasa.Tasa = row.Cells["Tasa"].Value.ToString();
                tasa.Cantidad = (float)row.Cells["Cantidad"].Value;
                tasa.Fecha = DateTime.Parse(row.Cells["Fecha"].Value.ToString()).ToString("dd-MM-yyyy");
                tasas.Add(tasa);
            }
        }
    }
}
