﻿namespace AdminInversiones.Forms
{
    partial class frm_Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarDoc = new System.Windows.Forms.Button();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 727);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBajaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBajaUsuario.Image = global::AdminInversiones.Properties.Resources.remove;
            this.btnBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaUsuario.Location = new System.Drawing.Point(1089, 12);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(254, 70);
            this.btnBajaUsuario.TabIndex = 1;
            this.btnBajaUsuario.Text = "Baja usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1087, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generar lista de usuarios:";
            // 
            // btnGenerarDoc
            // 
            this.btnGenerarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnGenerarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDoc.ForeColor = System.Drawing.Color.White;
            this.btnGenerarDoc.Image = global::AdminInversiones.Properties.Resources.pdf;
            this.btnGenerarDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarDoc.Location = new System.Drawing.Point(1089, 113);
            this.btnGenerarDoc.Name = "btnGenerarDoc";
            this.btnGenerarDoc.Size = new System.Drawing.Size(254, 70);
            this.btnGenerarDoc.TabIndex = 8;
            this.btnGenerarDoc.Text = "Generar PDF";
            this.btnGenerarDoc.UseVisualStyleBackColor = false;
            this.btnGenerarDoc.Click += new System.EventHandler(this.btnGenerarDoc_Click);
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnGenerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarExcel.ForeColor = System.Drawing.Color.White;
            this.btnGenerarExcel.Image = global::AdminInversiones.Properties.Resources.excel;
            this.btnGenerarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarExcel.Location = new System.Drawing.Point(1089, 189);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(251, 70);
            this.btnGenerarExcel.TabIndex = 9;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = false;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.btnGenerarDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Usuarios";
            this.Text = "frm_Usuarios";
            this.Load += new System.EventHandler(this.frm_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBajaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarDoc;
        private System.Windows.Forms.Button btnGenerarExcel;
    }
}