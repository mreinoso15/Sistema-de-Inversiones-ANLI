using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones.Forms
{
    public partial class frm_DepositosRetiros : Form
    {
        ConexionBD conexion;
        int idusuario = 0;
        public frm_DepositosRetiros()
        {
            InitializeComponent();
        }

        private void frm_DepositosRetiros_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            cmb_Socios = conexion.obtenerNoSocio(cmb_Socios);
            SetMyCustomFormat();
            dtgDepositos.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dtgDepositosCalculados.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dtgRetiros.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFechaDR.Format = DateTimePickerFormat.Custom;
            dtpFechaDR.CustomFormat = "MM/yyyy";
            dtpFechaDR.ShowUpDown = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            idusuario = Int32.Parse(cmb_Socios.SelectedValue.ToString());

            string fechaInicio = dtpFechaDR.Value.Year.ToString() + "-" +
                          dtpFechaDR.Value.Month.ToString() + "-" +
                          dtpFechaDR.Value.Day.ToString();

            if (idusuario != 0)
            {
                dtgDepositos.DataSource = conexion.obtenerDepositosUsuario(idusuario,fechaInicio);
                dtgDepositosCalculados.DataSource = conexion.obtenerDCalculadosUsuario(idusuario,fechaInicio);
                dtgRetiros.DataSource = conexion.obtenerRetirosUsuario(idusuario,fechaInicio);
                //MessageBox.Show(cmb_Socios.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un usuario valido primero", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
