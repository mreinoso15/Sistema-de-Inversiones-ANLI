namespace AdminInversiones
{
    partial class frm_Reportes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ExcelSocio = new System.Windows.Forms.Button();
            this.btn_PDFSocio = new System.Windows.Forms.Button();
            this.date_FinReporteSocio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_InicioReporteSocio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ExcelFecha = new System.Windows.Forms.Button();
            this.btn_PDFecha = new System.Windows.Forms.Button();
            this.date_FinReporteFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_InicioReporteFecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_Socios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Socios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ExcelSocio);
            this.groupBox1.Controls.Add(this.btn_PDFSocio);
            this.groupBox1.Controls.Add(this.date_FinReporteSocio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_InicioReporteSocio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 361);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar reporte por socio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. Socio: ";
            // 
            // btn_ExcelSocio
            // 
            this.btn_ExcelSocio.Location = new System.Drawing.Point(404, 149);
            this.btn_ExcelSocio.Name = "btn_ExcelSocio";
            this.btn_ExcelSocio.Size = new System.Drawing.Size(170, 59);
            this.btn_ExcelSocio.TabIndex = 5;
            this.btn_ExcelSocio.Text = "Generar Reporte Excel";
            this.btn_ExcelSocio.UseVisualStyleBackColor = true;
            // 
            // btn_PDFSocio
            // 
            this.btn_PDFSocio.Location = new System.Drawing.Point(404, 65);
            this.btn_PDFSocio.Name = "btn_PDFSocio";
            this.btn_PDFSocio.Size = new System.Drawing.Size(170, 59);
            this.btn_PDFSocio.TabIndex = 4;
            this.btn_PDFSocio.Text = "Generar Reporte PDF";
            this.btn_PDFSocio.UseVisualStyleBackColor = true;
            this.btn_PDFSocio.Click += new System.EventHandler(this.btn_PDFSocio_Click);
            // 
            // date_FinReporteSocio
            // 
            this.date_FinReporteSocio.Location = new System.Drawing.Point(10, 163);
            this.date_FinReporteSocio.Name = "date_FinReporteSocio";
            this.date_FinReporteSocio.Size = new System.Drawing.Size(292, 26);
            this.date_FinReporteSocio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicial:";
            // 
            // date_InicioReporteSocio
            // 
            this.date_InicioReporteSocio.Location = new System.Drawing.Point(6, 79);
            this.date_InicioReporteSocio.Name = "date_InicioReporteSocio";
            this.date_InicioReporteSocio.Size = new System.Drawing.Size(296, 26);
            this.date_InicioReporteSocio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ExcelFecha);
            this.groupBox2.Controls.Add(this.btn_PDFecha);
            this.groupBox2.Controls.Add(this.date_FinReporteFecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date_InicioReporteFecha);
            this.groupBox2.Location = new System.Drawing.Point(12, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 360);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar reporte general por fecha";
            // 
            // btn_ExcelFecha
            // 
            this.btn_ExcelFecha.Location = new System.Drawing.Point(408, 160);
            this.btn_ExcelFecha.Name = "btn_ExcelFecha";
            this.btn_ExcelFecha.Size = new System.Drawing.Size(170, 59);
            this.btn_ExcelFecha.TabIndex = 11;
            this.btn_ExcelFecha.Text = "Generar Reporte Excel";
            this.btn_ExcelFecha.UseVisualStyleBackColor = true;
            // 
            // btn_PDFecha
            // 
            this.btn_PDFecha.Location = new System.Drawing.Point(408, 76);
            this.btn_PDFecha.Name = "btn_PDFecha";
            this.btn_PDFecha.Size = new System.Drawing.Size(170, 59);
            this.btn_PDFecha.TabIndex = 10;
            this.btn_PDFecha.Text = "Generar Reporte PDF";
            this.btn_PDFecha.UseVisualStyleBackColor = true;
            // 
            // date_FinReporteFecha
            // 
            this.date_FinReporteFecha.Location = new System.Drawing.Point(14, 174);
            this.date_FinReporteFecha.Name = "date_FinReporteFecha";
            this.date_FinReporteFecha.Size = new System.Drawing.Size(292, 26);
            this.date_FinReporteFecha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha inicial:";
            // 
            // date_InicioReporteFecha
            // 
            this.date_InicioReporteFecha.Location = new System.Drawing.Point(10, 90);
            this.date_InicioReporteFecha.Name = "date_InicioReporteFecha";
            this.date_InicioReporteFecha.Size = new System.Drawing.Size(296, 26);
            this.date_InicioReporteFecha.TabIndex = 6;
            // 
            // cmb_Socios
            // 
            this.cmb_Socios.FormattingEnabled = true;
            this.cmb_Socios.Location = new System.Drawing.Point(10, 251);
            this.cmb_Socios.Name = "cmb_Socios";
            this.cmb_Socios.Size = new System.Drawing.Size(292, 28);
            this.cmb_Socios.TabIndex = 6;
            // 
            // frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Reportes";
            this.Text = "frm_Reportes";
            this.Load += new System.EventHandler(this.frm_Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ExcelSocio;
        private System.Windows.Forms.Button btn_PDFSocio;
        private System.Windows.Forms.DateTimePicker date_FinReporteSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_InicioReporteSocio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ExcelFecha;
        private System.Windows.Forms.Button btn_PDFecha;
        private System.Windows.Forms.DateTimePicker date_FinReporteFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_InicioReporteFecha;
        private System.Windows.Forms.ComboBox cmb_Socios;
    }
}