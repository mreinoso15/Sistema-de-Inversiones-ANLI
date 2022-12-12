namespace AdminInversiones
{
    partial class frm_SolicitudRetiro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Principal = new System.Windows.Forms.Button();
            this.btn_Registros = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Deposito = new System.Windows.Forms.Button();
            this.btn_Intereses = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Motivos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aprovar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Rechazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 840);
            this.panel2.TabIndex = 1;
            // 
            // btn_Principal
            // 
            this.btn_Principal.BackColor = System.Drawing.Color.Bisque;
            this.btn_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Principal.Location = new System.Drawing.Point(3, 101);
            this.btn_Principal.Name = "btn_Principal";
            this.btn_Principal.Size = new System.Drawing.Size(277, 122);
            this.btn_Principal.TabIndex = 2;
            this.btn_Principal.Text = "Menu Principal";
            this.btn_Principal.UseVisualStyleBackColor = false;
            this.btn_Principal.Click += new System.EventHandler(this.btn_Principal_Click);
            // 
            // btn_Registros
            // 
            this.btn_Registros.BackColor = System.Drawing.Color.Bisque;
            this.btn_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registros.Location = new System.Drawing.Point(3, 223);
            this.btn_Registros.Name = "btn_Registros";
            this.btn_Registros.Size = new System.Drawing.Size(277, 122);
            this.btn_Registros.TabIndex = 3;
            this.btn_Registros.Text = "Solicitudes de Registro al Sistema";
            this.btn_Registros.UseVisualStyleBackColor = false;
            this.btn_Registros.Click += new System.EventHandler(this.btn_Registros_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.Bisque;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Location = new System.Drawing.Point(3, 345);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(277, 122);
            this.btn_Reportes.TabIndex = 4;
            this.btn_Reportes.Text = "Generar Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Deposito
            // 
            this.btn_Deposito.BackColor = System.Drawing.Color.Bisque;
            this.btn_Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposito.Location = new System.Drawing.Point(3, 467);
            this.btn_Deposito.Name = "btn_Deposito";
            this.btn_Deposito.Size = new System.Drawing.Size(277, 122);
            this.btn_Deposito.TabIndex = 5;
            this.btn_Deposito.Text = "Solicitudes de Deposito";
            this.btn_Deposito.UseVisualStyleBackColor = false;
            this.btn_Deposito.Click += new System.EventHandler(this.btn_Deposito_Click);
            // 
            // btn_Intereses
            // 
            this.btn_Intereses.BackColor = System.Drawing.Color.Bisque;
            this.btn_Intereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Intereses.Location = new System.Drawing.Point(3, 589);
            this.btn_Intereses.Name = "btn_Intereses";
            this.btn_Intereses.Size = new System.Drawing.Size(277, 122);
            this.btn_Intereses.TabIndex = 6;
            this.btn_Intereses.Text = "Ingresar Interes ";
            this.btn_Intereses.UseVisualStyleBackColor = false;
            this.btn_Intereses.Click += new System.EventHandler(this.btn_Intereses_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Bisque;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(3, 711);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(277, 122);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Cerrar Sesion ";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(960, 727);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmb_Motivos
            // 
            this.cmb_Motivos.FormattingEnabled = true;
            this.cmb_Motivos.Items.AddRange(new object[] {
            "Motivo 1",
            "Motivo 2",
            "Motivo 3",
            "Motivo 4"});
            this.cmb_Motivos.Location = new System.Drawing.Point(1294, 149);
            this.cmb_Motivos.Name = "cmb_Motivos";
            this.cmb_Motivos.Size = new System.Drawing.Size(239, 28);
            this.cmb_Motivos.TabIndex = 9;
            this.cmb_Motivos.Text = "Seleccionar Motivo...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1290, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Motivo del retiro:";
            // 
            // btn_Aprovar
            // 
            this.btn_Aprovar.Location = new System.Drawing.Point(1294, 223);
            this.btn_Aprovar.Name = "btn_Aprovar";
            this.btn_Aprovar.Size = new System.Drawing.Size(230, 97);
            this.btn_Aprovar.TabIndex = 11;
            this.btn_Aprovar.Text = "Aprovar Retiro";
            this.btn_Aprovar.UseVisualStyleBackColor = true;
            this.btn_Aprovar.Click += new System.EventHandler(this.btn_Aprovar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(576, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Solicitud de Retiros";
            // 
            // btn_Rechazar
            // 
            this.btn_Rechazar.Location = new System.Drawing.Point(1294, 345);
            this.btn_Rechazar.Name = "btn_Rechazar";
            this.btn_Rechazar.Size = new System.Drawing.Size(230, 97);
            this.btn_Rechazar.TabIndex = 13;
            this.btn_Rechazar.Text = "Rechazar Retiro";
            this.btn_Rechazar.UseVisualStyleBackColor = true;
            this.btn_Rechazar.Click += new System.EventHandler(this.btn_Rechazar_Click);
            // 
            // frm_SolicitudRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 837);
            this.Controls.Add(this.btn_Rechazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Aprovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Motivos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Intereses);
            this.Controls.Add(this.btn_Deposito);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Registros);
            this.Controls.Add(this.btn_Principal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_SolicitudRetiro";
            this.Text = "frm_SolicitudRetiro";
            this.Load += new System.EventHandler(this.frm_SolicitudRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Principal;
        private System.Windows.Forms.Button btn_Registros;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Deposito;
        private System.Windows.Forms.Button btn_Intereses;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Motivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aprovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Rechazar;
    }
}