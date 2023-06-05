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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tasas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAsignarTasas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.txtActualizarImpuestos = new System.Windows.Forms.NumericUpDown();
            this.btn_ActualizarImpuesto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.grp_formularioInteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorTasa)).BeginInit();
            this.grpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorActualizar)).BeginInit();
            this.grpAsignarTasas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualizarImpuestos)).BeginInit();
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
            this.btn_ingresarTasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresarTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresarTasa.Location = new System.Drawing.Point(273, 226);
            this.btn_ingresarTasa.Name = "btn_ingresarTasa";
            this.btn_ingresarTasa.Size = new System.Drawing.Size(108, 43);
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
            this.grpActualizar.Controls.Add(this.txt_valorActualizar);
            this.grpActualizar.Controls.Add(this.btn_aceptar);
            this.grpActualizar.Controls.Add(this.label7);
            this.grpActualizar.Controls.Add(this.cmb_tasas);
            this.grpActualizar.Controls.Add(this.label6);
            this.grpActualizar.Location = new System.Drawing.Point(12, 308);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(403, 174);
            this.grpActualizar.TabIndex = 9;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar tasa:";
            // 
            // txt_valorActualizar
            // 
            this.txt_valorActualizar.DecimalPlaces = 2;
            this.txt_valorActualizar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_valorActualizar.Location = new System.Drawing.Point(191, 66);
            this.txt_valorActualizar.Name = "txt_valorActualizar";
            this.txt_valorActualizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorActualizar.Size = new System.Drawing.Size(190, 26);
            this.txt_valorActualizar.TabIndex = 10;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(247, 109);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(134, 50);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Actualizar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nuevo valor:";
            // 
            // cmb_tasas
            // 
            this.cmb_tasas.FormattingEnabled = true;
            this.cmb_tasas.Location = new System.Drawing.Point(191, 25);
            this.cmb_tasas.Name = "cmb_tasas";
            this.cmb_tasas.Size = new System.Drawing.Size(190, 28);
            this.cmb_tasas.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tasa a actualizar:";
            // 
            // grpAsignarTasas
            // 
            this.grpAsignarTasas.Controls.Add(this.dataGridView1);
            this.grpAsignarTasas.Location = new System.Drawing.Point(447, 20);
            this.grpAsignarTasas.Name = "grpAsignarTasas";
            this.grpAsignarTasas.Size = new System.Drawing.Size(827, 706);
            this.grpAsignarTasas.TabIndex = 10;
            this.grpAsignarTasas.TabStop = false;
            this.grpAsignarTasas.Text = "Historial de tasas de intereses previos";
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
            this.dataGridView1.Size = new System.Drawing.Size(815, 675);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.txtActualizarImpuestos);
            this.grpEliminar.Controls.Add(this.btn_ActualizarImpuesto);
            this.grpEliminar.Controls.Add(this.label9);
            this.grpEliminar.Location = new System.Drawing.Point(12, 488);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(403, 138);
            this.grpEliminar.TabIndex = 11;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Actualizar el impuesto a los intereses:";
            // 
            // txtActualizarImpuestos
            // 
            this.txtActualizarImpuestos.DecimalPlaces = 2;
            this.txtActualizarImpuestos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtActualizarImpuestos.Location = new System.Drawing.Point(191, 31);
            this.txtActualizarImpuestos.Name = "txtActualizarImpuestos";
            this.txtActualizarImpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtActualizarImpuestos.Size = new System.Drawing.Size(190, 26);
            this.txtActualizarImpuestos.TabIndex = 11;
            // 
            // btn_ActualizarImpuesto
            // 
            this.btn_ActualizarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarImpuesto.Location = new System.Drawing.Point(247, 71);
            this.btn_ActualizarImpuesto.Name = "btn_ActualizarImpuesto";
            this.btn_ActualizarImpuesto.Size = new System.Drawing.Size(134, 45);
            this.btn_ActualizarImpuesto.TabIndex = 2;
            this.btn_ActualizarImpuesto.Text = "Actualizar";
            this.btn_ActualizarImpuesto.UseVisualStyleBackColor = true;
            this.btn_ActualizarImpuesto.Click += new System.EventHandler(this.btn_ActualizarImpuesto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor impuesto:";
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnGenerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarExcel.ForeColor = System.Drawing.Color.White;
            this.btnGenerarExcel.Image = global::AdminInversiones.Properties.Resources.excel;
            this.btnGenerarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarExcel.Location = new System.Drawing.Point(1280, 32);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(212, 119);
            this.btnGenerarExcel.TabIndex = 12;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarExcel.UseVisualStyleBackColor = false;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // frm_IngresarInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.btnGenerarExcel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualizarImpuestos)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ingresarTasa;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btn_ActualizarImpuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txt_valorTasa;
        private System.Windows.Forms.NumericUpDown txt_valorActualizar;
        private System.Windows.Forms.NumericUpDown txtActualizarImpuestos;
        private System.Windows.Forms.Button btnGenerarExcel;
    }
}