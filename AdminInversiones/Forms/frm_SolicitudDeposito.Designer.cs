namespace AdminInversiones
{
    partial class frm_SolicitudDeposito
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Rechazar = new System.Windows.Forms.Button();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(960, 727);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Image = global::AdminInversiones.Properties.Resources._checked;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(978, 82);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(230, 108);
            this.btn_Aceptar.TabIndex = 9;
            this.btn_Aceptar.Text = "Aceptar Deposito";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Rechazar
            // 
            this.btn_Rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Rechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Rechazar.ForeColor = System.Drawing.Color.White;
            this.btn_Rechazar.Image = global::AdminInversiones.Properties.Resources.remove;
            this.btn_Rechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rechazar.Location = new System.Drawing.Point(978, 196);
            this.btn_Rechazar.Name = "btn_Rechazar";
            this.btn_Rechazar.Size = new System.Drawing.Size(230, 108);
            this.btn_Rechazar.TabIndex = 10;
            this.btn_Rechazar.Text = "Rechazar";
            this.btn_Rechazar.UseVisualStyleBackColor = false;
            this.btn_Rechazar.Click += new System.EventHandler(this.btn_Rechazar_Click);
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(978, 50);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(230, 26);
            this.txtFolio.TabIndex = 11;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(978, 12);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(131, 29);
            this.lblFolio.TabIndex = 12;
            this.lblFolio.Text = "# de Folio";
            // 
            // frm_SolicitudDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.ControlBox = false;
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.btn_Rechazar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_SolicitudDeposito";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_SolicitudDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Rechazar;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblFolio;
    }
}