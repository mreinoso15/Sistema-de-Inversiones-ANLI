namespace AdminInversiones
{
    partial class frm_IngresarInteres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_formularioInteres = new System.Windows.Forms.GroupBox();
            this.txt_valorTasa = new System.Windows.Forms.NumericUpDown();
            this.btn_ingresarTasa = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tipoTasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.txt_valorActualizar = new System.Windows.Forms.NumericUpDown();
            this.txt_descripcionActualizar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_actualizarTipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tasas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAsignarTasas = new System.Windows.Forms.GroupBox();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.cmb_tasasAsignar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cmb_tasasEliminar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkActualizar = new System.Windows.Forms.CheckBox();
            this.grp_formularioInteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorTasa)).BeginInit();
            this.grpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorActualizar)).BeginInit();
            this.grpAsignarTasas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_formularioInteres
            // 
            this.grp_formularioInteres.Controls.Add(this.txt_valorTasa);
            this.grp_formularioInteres.Controls.Add(this.btn_ingresarTasa);
            this.grp_formularioInteres.Controls.Add(this.txt_descripcion);
            this.grp_formularioInteres.Controls.Add(this.label5);
            this.grp_formularioInteres.Controls.Add(this.txt_tipoTasa);
            this.grp_formularioInteres.Controls.Add(this.label4);
            this.grp_formularioInteres.Controls.Add(this.label3);
            this.grp_formularioInteres.Location = new System.Drawing.Point(12, 12);
            this.grp_formularioInteres.Name = "grp_formularioInteres";
            this.grp_formularioInteres.Size = new System.Drawing.Size(403, 290);
            this.grp_formularioInteres.TabIndex = 8;
            this.grp_formularioInteres.TabStop = false;
            this.grp_formularioInteres.Text = "Ingresar nueva tasa";
            // 
            // txt_valorTasa
            // 
            this.txt_valorTasa.DecimalPlaces = 2;
            this.txt_valorTasa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_valorTasa.Location = new System.Drawing.Point(145, 42);
            this.txt_valorTasa.Name = "txt_valorTasa";
            this.txt_valorTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorTasa.Size = new System.Drawing.Size(236, 26);
            this.txt_valorTasa.TabIndex = 9;
            // 
            // btn_ingresarTasa
            // 
            this.btn_ingresarTasa.Location = new System.Drawing.Point(289, 226);
            this.btn_ingresarTasa.Name = "btn_ingresarTasa";
            this.btn_ingresarTasa.Size = new System.Drawing.Size(92, 43);
            this.btn_ingresarTasa.TabIndex = 8;
            this.btn_ingresarTasa.Text = "Ingresar";
            this.btn_ingresarTasa.UseVisualStyleBackColor = true;
            this.btn_ingresarTasa.Click += new System.EventHandler(this.btn_ingresarTasa_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(145, 123);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(236, 94);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion:";
            // 
            // txt_tipoTasa
            // 
            this.txt_tipoTasa.Location = new System.Drawing.Point(145, 80);
            this.txt_tipoTasa.Name = "txt_tipoTasa";
            this.txt_tipoTasa.Size = new System.Drawing.Size(236, 26);
            this.txt_tipoTasa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Tasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Tasa:";
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.chkActualizar);
            this.grpActualizar.Controls.Add(this.txt_valorActualizar);
            this.grpActualizar.Controls.Add(this.txt_descripcionActualizar);
            this.grpActualizar.Controls.Add(this.label11);
            this.grpActualizar.Controls.Add(this.txt_actualizarTipo);
            this.grpActualizar.Controls.Add(this.label10);
            this.grpActualizar.Controls.Add(this.btn_aceptar);
            this.grpActualizar.Controls.Add(this.label7);
            this.grpActualizar.Controls.Add(this.cmb_tasas);
            this.grpActualizar.Controls.Add(this.label6);
            this.grpActualizar.Location = new System.Drawing.Point(12, 308);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(403, 325);
            this.grpActualizar.TabIndex = 9;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar tasa:";
            // 
            // txt_valorActualizar
            // 
            this.txt_valorActualizar.DecimalPlaces = 2;
            this.txt_valorActualizar.Enabled = false;
            this.txt_valorActualizar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_valorActualizar.Location = new System.Drawing.Point(191, 112);
            this.txt_valorActualizar.Name = "txt_valorActualizar";
            this.txt_valorActualizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorActualizar.Size = new System.Drawing.Size(190, 26);
            this.txt_valorActualizar.TabIndex = 10;
            // 
            // txt_descripcionActualizar
            // 
            this.txt_descripcionActualizar.Enabled = false;
            this.txt_descripcionActualizar.Location = new System.Drawing.Point(191, 187);
            this.txt_descripcionActualizar.Multiline = true;
            this.txt_descripcionActualizar.Name = "txt_descripcionActualizar";
            this.txt_descripcionActualizar.Size = new System.Drawing.Size(190, 62);
            this.txt_descripcionActualizar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Actualizar descripcion:";
            // 
            // txt_actualizarTipo
            // 
            this.txt_actualizarTipo.Enabled = false;
            this.txt_actualizarTipo.Location = new System.Drawing.Point(191, 151);
            this.txt_actualizarTipo.Name = "txt_actualizarTipo";
            this.txt_actualizarTipo.Size = new System.Drawing.Size(190, 26);
            this.txt_actualizarTipo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Actualizar Tipo:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Location = new System.Drawing.Point(289, 255);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(92, 35);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nuevo valor:";
            // 
            // cmb_tasas
            // 
            this.cmb_tasas.Enabled = false;
            this.cmb_tasas.FormattingEnabled = true;
            this.cmb_tasas.Location = new System.Drawing.Point(191, 71);
            this.cmb_tasas.Name = "cmb_tasas";
            this.cmb_tasas.Size = new System.Drawing.Size(190, 28);
            this.cmb_tasas.TabIndex = 1;
            this.cmb_tasas.SelectedIndexChanged += new System.EventHandler(this.cmb_tasas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tasa a actualizar:";
            // 
            // grpAsignarTasas
            // 
            this.grpAsignarTasas.Controls.Add(this.btn_asignar);
            this.grpAsignarTasas.Controls.Add(this.cmb_tasasAsignar);
            this.grpAsignarTasas.Controls.Add(this.label8);
            this.grpAsignarTasas.Controls.Add(this.dataGridView1);
            this.grpAsignarTasas.Location = new System.Drawing.Point(447, 20);
            this.grpAsignarTasas.Name = "grpAsignarTasas";
            this.grpAsignarTasas.Size = new System.Drawing.Size(827, 706);
            this.grpAsignarTasas.TabIndex = 10;
            this.grpAsignarTasas.TabStop = false;
            this.grpAsignarTasas.Text = "Asignacion de tasa a clientes";
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(644, 103);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(177, 36);
            this.btn_asignar.TabIndex = 3;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // cmb_tasasAsignar
            // 
            this.cmb_tasasAsignar.FormattingEnabled = true;
            this.cmb_tasasAsignar.Location = new System.Drawing.Point(644, 52);
            this.cmb_tasasAsignar.Name = "cmb_tasasAsignar";
            this.cmb_tasasAsignar.Size = new System.Drawing.Size(177, 28);
            this.cmb_tasasAsignar.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tasas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(628, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.btn_eliminar);
            this.grpEliminar.Controls.Add(this.cmb_tasasEliminar);
            this.grpEliminar.Controls.Add(this.label9);
            this.grpEliminar.Location = new System.Drawing.Point(12, 639);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(403, 138);
            this.grpEliminar.TabIndex = 11;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar tasa";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(292, 71);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 29);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // cmb_tasasEliminar
            // 
            this.cmb_tasasEliminar.FormattingEnabled = true;
            this.cmb_tasasEliminar.Location = new System.Drawing.Point(191, 28);
            this.cmb_tasasEliminar.Name = "cmb_tasasEliminar";
            this.cmb_tasasEliminar.Size = new System.Drawing.Size(190, 28);
            this.cmb_tasasEliminar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tasa a eliminar:";
            // 
            // chkActualizar
            // 
            this.chkActualizar.AutoSize = true;
            this.chkActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActualizar.Location = new System.Drawing.Point(48, 25);
            this.chkActualizar.Name = "chkActualizar";
            this.chkActualizar.Size = new System.Drawing.Size(315, 33);
            this.chkActualizar.TabIndex = 15;
            this.chkActualizar.Text = "Actualizar datos de tasa";
            this.chkActualizar.UseVisualStyleBackColor = true;
            this.chkActualizar.CheckedChanged += new System.EventHandler(this.chkActualizar_CheckedChanged);
            // 
            // frm_IngresarInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.grpAsignarTasas);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.grp_formularioInteres);
            this.Name = "frm_IngresarInteres";
            this.Text = "frm_IngresarInteres";
            this.Load += new System.EventHandler(this.frm_IngresarInteres_Load);
            this.grp_formularioInteres.ResumeLayout(false);
            this.grp_formularioInteres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorTasa)).EndInit();
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorActualizar)).EndInit();
            this.grpAsignarTasas.ResumeLayout(false);
            this.grpAsignarTasas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_formularioInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tipoTasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tasas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpAsignarTasas;
        private System.Windows.Forms.ComboBox cmb_tasasAsignar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ingresarTasa;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cmb_tasasEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descripcionActualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_actualizarTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txt_valorTasa;
        private System.Windows.Forms.NumericUpDown txt_valorActualizar;
        private System.Windows.Forms.CheckBox chkActualizar;
    }
}