using System;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Aprobar = new System.Windows.Forms.Button();
            this.btn_Rechazar = new System.Windows.Forms.Button();
            this.txtCantidadRetiro = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadRetiro)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(960, 727);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Aprobar
            // 
            this.btn_Aprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Aprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Aprobar.ForeColor = System.Drawing.Color.White;
            this.btn_Aprobar.Image = global::AdminInversiones.Properties.Resources._checked;
            this.btn_Aprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aprobar.Location = new System.Drawing.Point(1003, 123);
            this.btn_Aprobar.Name = "btn_Aprobar";
            this.btn_Aprobar.Size = new System.Drawing.Size(230, 65);
            this.btn_Aprobar.TabIndex = 11;
            this.btn_Aprobar.Text = "Aprobar Retiro";
            this.btn_Aprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aprobar.UseVisualStyleBackColor = false;
            this.btn_Aprobar.Click += new System.EventHandler(this.btn_Aprobar_Click);
            // 
            // btn_Rechazar
            // 
            this.btn_Rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Rechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Rechazar.ForeColor = System.Drawing.Color.White;
            this.btn_Rechazar.Image = global::AdminInversiones.Properties.Resources.remove;
            this.btn_Rechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rechazar.Location = new System.Drawing.Point(1003, 209);
            this.btn_Rechazar.Name = "btn_Rechazar";
            this.btn_Rechazar.Size = new System.Drawing.Size(230, 65);
            this.btn_Rechazar.TabIndex = 13;
            this.btn_Rechazar.Text = "Rechazar Retiro";
            this.btn_Rechazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Rechazar.UseVisualStyleBackColor = false;
            this.btn_Rechazar.Click += new System.EventHandler(this.btn_Rechazar_Click);
            // 
            // txtCantidadRetiro
            // 
            this.txtCantidadRetiro.DecimalPlaces = 2;
            this.txtCantidadRetiro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCantidadRetiro.Location = new System.Drawing.Point(1003, 76);
            this.txtCantidadRetiro.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtCantidadRetiro.Name = "txtCantidadRetiro";
            this.txtCantidadRetiro.Size = new System.Drawing.Size(230, 26);
            this.txtCantidadRetiro.TabIndex = 15;
            this.txtCantidadRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(998, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad a retirar:";
            // 
            // frm_SolicitudRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1545, 837);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadRetiro);
            this.Controls.Add(this.btn_Rechazar);
            this.Controls.Add(this.btn_Aprobar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_SolicitudRetiro";
            this.Text = "frm_SolicitudRetiro";
            this.Load += new System.EventHandler(this.frm_SolicitudRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadRetiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Aprobar;
        private System.Windows.Forms.Button btn_Rechazar;
        private System.Windows.Forms.NumericUpDown txtCantidadRetiro;
        private System.Windows.Forms.Label label1;
        
    }
}