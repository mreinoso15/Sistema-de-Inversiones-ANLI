namespace AdminInversiones
{
    partial class frm_SolicitudesRegistro
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
            this.btn_AceptarSolicitud = new System.Windows.Forms.Button();
            this.btn_RechazarSolicitud = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(697, 488);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_AceptarSolicitud
            // 
            this.btn_AceptarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_AceptarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AceptarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AceptarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btn_AceptarSolicitud.Image = global::AdminInversiones.Properties.Resources._checked;
            this.btn_AceptarSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AceptarSolicitud.Location = new System.Drawing.Point(726, 12);
            this.btn_AceptarSolicitud.Name = "btn_AceptarSolicitud";
            this.btn_AceptarSolicitud.Size = new System.Drawing.Size(172, 71);
            this.btn_AceptarSolicitud.TabIndex = 2;
            this.btn_AceptarSolicitud.Text = "Aceptar Solicitud";
            this.btn_AceptarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AceptarSolicitud.UseVisualStyleBackColor = false;
            this.btn_AceptarSolicitud.Click += new System.EventHandler(this.btn_AceptarSolicitud_Click);
            // 
            // btn_RechazarSolicitud
            // 
            this.btn_RechazarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_RechazarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RechazarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_RechazarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btn_RechazarSolicitud.Image = global::AdminInversiones.Properties.Resources.remove;
            this.btn_RechazarSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RechazarSolicitud.Location = new System.Drawing.Point(726, 89);
            this.btn_RechazarSolicitud.Name = "btn_RechazarSolicitud";
            this.btn_RechazarSolicitud.Size = new System.Drawing.Size(172, 71);
            this.btn_RechazarSolicitud.TabIndex = 3;
            this.btn_RechazarSolicitud.Text = "Rechazar Solicitud";
            this.btn_RechazarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RechazarSolicitud.UseVisualStyleBackColor = false;
            this.btn_RechazarSolicitud.Click += new System.EventHandler(this.btn_RechazarSolicitud_Click);
            // 
            // frm_SolicitudesRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.btn_RechazarSolicitud);
            this.Controls.Add(this.btn_AceptarSolicitud);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.Name = "frm_SolicitudesRegistro";
            this.Text = "frm_SolicitudesRegistro";
            this.Load += new System.EventHandler(this.frm_SolicitudesRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AceptarSolicitud;
        private System.Windows.Forms.Button btn_RechazarSolicitud;
    }
}