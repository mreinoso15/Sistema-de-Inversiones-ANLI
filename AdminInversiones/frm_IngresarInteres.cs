using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdminInversiones
{
    

    public partial class frm_IngresarInteres : Form
    {
        private bool bandera = false;
        private int idusuario;
        private int idtasa;
        ConexionBD conexion;
        public frm_IngresarInteres()
        {
            InitializeComponent();
        }

        private void frm_IngresarInteres_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerClientesTasas();
            cmb_tasas = conexion.obtenerTasasInversiones(cmb_tasas);
            cmb_tasasAsignar = conexion.obtenerTasasInversiones(cmb_tasasAsignar);
            cmb_tasasEliminar = conexion.obtenerTasasInversiones(cmb_tasasEliminar);
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Principal principal = new frm_Principal();
            principal.ShowDialog();
            this.Close();
        }

        private void btn_solicitudesRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudesRegistro registros = new frm_SolicitudesRegistro();
            registros.ShowDialog();
            this.Close();
        }

        private void btn_generarReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Reportes reportes = new frm_Reportes();
            reportes.ShowDialog();
            this.Close();
        }

        private void btn_solicitudesDeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudDeposito depositos = new frm_SolicitudDeposito();
            depositos.ShowDialog();
            this.Close();
        }

        private void btn_solicitudesRetiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SolicitudRetiro retiros = new frm_SolicitudRetiro();
            retiros.ShowDialog();
            this.Close();
        }

        private void btn_ingresarTasa_Click(object sender, EventArgs e)
        {
            if (validarCampos() == false) MessageBox.Show("Faltan datos por llenar, revisa de nuevo los campos");
            else {
                double tasa = Double.Parse(txt_valorTasa.Value.ToString());
                string tipo = txt_tipoTasa.Text;
                string descripcion = txt_descripcion.Text;
                conexion.insertarTasaInteres(tasa, tipo, descripcion);
                MessageBox.Show("Datos insertados");
                limpiarCamposInsertar();
                cmb_tasas = conexion.obtenerTasasInversiones(cmb_tasas);
                cmb_tasasAsignar = conexion.obtenerTasasInversiones(cmb_tasasAsignar);
                cmb_tasasEliminar = conexion.obtenerTasasInversiones(cmb_tasasEliminar);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idusuario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID Socio"].Value.ToString());
            //MessageBox.Show(idusuario + "  "+idtasa);
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            if (bandera == false) MessageBox.Show("No ha seleccionado un socio \n Seleccione uno antes de asignar la nueva tasa");
            idtasa = cmb_tasasAsignar.SelectedIndex + 1;
        }
    }
}
