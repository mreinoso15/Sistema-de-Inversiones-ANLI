using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminInversiones
{
    public partial class frm_SolicitudRetiro : Form
    {
        private ConexionBD conexionBD;
        private List<Inversiones> inversiones;
        private List<int> listaDias;
        private List<double> listaIntereses;
        int idRetiro, idUsuario;
        double cantidadRetiro;
        ConexionBD conexion;
        public frm_SolicitudRetiro()
        {
            InitializeComponent();
        }

        private void frm_SolicitudRetiro_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesRetiro();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRetiro = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID Retiro"].Value.ToString());
            idUsuario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["No. Socio"].Value.ToString());
        }

        private void btn_Aprobar_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show($"Esta seguro que quiere retirar: \n {txtCantidadRetiro.Value}",
                                                    "Advertencia",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning,
                                                    MessageBoxDefaultButton.Button2);

                double total = conexion.obtenerTotal(idUsuario);
                MessageBox.Show("El total del usuario es:"+total + "");
                if (total >= Decimal.ToDouble(txtCantidadRetiro.Value))
                {
                    switch (result)
                    {
                        case DialogResult.Yes:
                        try
                        {
                            cantidadRetiro = Decimal.ToDouble(txtCantidadRetiro.Value);
                            codigoBoton();
                            conexion.aceptarSolicitudRetiro(idRetiro, cantidadRetiro);
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            MessageBox.Show("La solicitud ha sido aceptada", "Retiros");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Favor de seleccionar una fila ", "Retiros");
                        }                      
                            break;

                        case DialogResult.No:
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("No tiene los fondos necesarios para realizar su retiro", "Retiros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
        }

        private void btn_Rechazar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.rechazarSolicitudRetiro(idRetiro);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido rechazada correctamente","Retiros", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }//Evento btnRechazar

        private void codigoBoton()
        {
            conexionBD = new ConexionBD();
            inversiones = conexionBD.obtenerInversiones(inversiones);
            calcularInteres(idUsuario);
            //actualizarIntereses();
        }
        private void calcularInteres(int idUsuario)
        {
            listaDias = new List<int>();
            listaIntereses = new List<double>();
            if (inversiones.Any())
            {
                MessageBox.Show("No hay inversiones a calcular", "Retiros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                for (int i = 0; i < inversiones.Count; i++)
                {
                    if (idUsuario == inversiones[i].NoSocio)
                    {
                        int diasInvertidos = (DateTime.Now - inversiones[i].Fecha).Days;
                        double interes = (Math.Round(inversiones[i].Tasa, 2) * diasInvertidos * Math.Round(inversiones[i].Cantidad, 2)) / 360;
                        listaIntereses.Add(Math.Round(interes, 2));
                        listaDias.Add(diasInvertidos);
                        conexionBD.actualizarInteresGenerado(inversiones[i].NoSocio, interes);
                        conexionBD.actualizarEstadoInteres(inversiones[i].solicitudInv);
                        /*cad += "# de Socio: " + inversiones[i].NoSocio + " " + "\n" +
                                "Interes generado: " + Math.Round(interes, 2) + "\n" +
                                "Calculado a " + diasInvertidos + " dias con una tasa de " + inversiones[i].Tasa + "\n\n";*/
                    }//IF
                }//FOR
                conexionBD.nuevoTotal(idUsuario);
                
            }//ELSE
            
        }

    }

}
