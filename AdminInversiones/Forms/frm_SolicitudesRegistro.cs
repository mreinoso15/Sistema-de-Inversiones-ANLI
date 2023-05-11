﻿using System;
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
    public partial class frm_SolicitudesRegistro : Form
    {
        ConexionBD conexion;
        int idSolicitud, idUsuario;
        public frm_SolicitudesRegistro()
        {
            InitializeComponent();
        }

        private void frm_SolicitudesRegistro_Load(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dataGridView1.DataSource = conexion.obtenerSolicitudesRegistro();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSolicitud = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID SOLICITUD"].Value.ToString());
            idUsuario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID USUARIO"].Value.ToString());
        }

        private void btn_AceptarSolicitud_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                double impuesto = conexion.obtenerImpuestos();
                conexion.aceptarSolicitudRegistro(idSolicitud);
                conexion.insertarImpuestosRegistro(idUsuario, impuesto);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido aceptada","Registro de usuarios",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero","Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_RechazarSolicitud_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                conexion.rechazarSolicitudRegistro(idSolicitud);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("La solicitud ha sido rechazada correctamente");

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila primero");
            }
        }
    }
}
