namespace AdminInversiones
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Interes = new System.Windows.Forms.Button();
            this.btn_Retiros = new System.Windows.Forms.Button();
            this.btn_Depositos = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Registros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btn_CalculoInteres = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Red;
            this.panelMenu.Controls.Add(this.btn_Cerrar);
            this.panelMenu.Controls.Add(this.btn_Interes);
            this.panelMenu.Controls.Add(this.btn_Retiros);
            this.panelMenu.Controls.Add(this.btn_Depositos);
            this.panelMenu.Controls.Add(this.btn_Reportes);
            this.panelMenu.Controls.Add(this.btn_Registros);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 670);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Snow;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cerrar.Location = new System.Drawing.Point(0, 550);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Cerrar.Size = new System.Drawing.Size(320, 120);
            this.btn_Cerrar.TabIndex = 12;
            this.btn_Cerrar.Text = "  Cerrar Sesión";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Interes
            // 
            this.btn_Interes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Interes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Interes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Interes.FlatAppearance.BorderSize = 0;
            this.btn_Interes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Interes.ForeColor = System.Drawing.Color.Snow;
            this.btn_Interes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Interes.Image")));
            this.btn_Interes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Interes.Location = new System.Drawing.Point(0, 470);
            this.btn_Interes.Name = "btn_Interes";
            this.btn_Interes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Interes.Size = new System.Drawing.Size(320, 80);
            this.btn_Interes.TabIndex = 11;
            this.btn_Interes.Text = "  Ingresar Interes ";
            this.btn_Interes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Interes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Interes.UseVisualStyleBackColor = false;
            this.btn_Interes.Click += new System.EventHandler(this.btn_Interes_Click);
            // 
            // btn_Retiros
            // 
            this.btn_Retiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Retiros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Retiros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Retiros.FlatAppearance.BorderSize = 0;
            this.btn_Retiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retiros.ForeColor = System.Drawing.Color.Snow;
            this.btn_Retiros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retiros.Image")));
            this.btn_Retiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Retiros.Location = new System.Drawing.Point(0, 390);
            this.btn_Retiros.Name = "btn_Retiros";
            this.btn_Retiros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Retiros.Size = new System.Drawing.Size(320, 80);
            this.btn_Retiros.TabIndex = 10;
            this.btn_Retiros.Text = "  Solicitudes de Retiro";
            this.btn_Retiros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Retiros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Retiros.UseVisualStyleBackColor = false;
            this.btn_Retiros.Click += new System.EventHandler(this.btn_Retiros_Click);
            // 
            // btn_Depositos
            // 
            this.btn_Depositos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Depositos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Depositos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Depositos.FlatAppearance.BorderSize = 0;
            this.btn_Depositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Depositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depositos.ForeColor = System.Drawing.Color.Snow;
            this.btn_Depositos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Depositos.Image")));
            this.btn_Depositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Depositos.Location = new System.Drawing.Point(0, 310);
            this.btn_Depositos.Name = "btn_Depositos";
            this.btn_Depositos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Depositos.Size = new System.Drawing.Size(320, 80);
            this.btn_Depositos.TabIndex = 9;
            this.btn_Depositos.Text = "  Solicitudes de Deposito";
            this.btn_Depositos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Depositos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Depositos.UseVisualStyleBackColor = false;
            this.btn_Depositos.Click += new System.EventHandler(this.btn_Depositos_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.Color.Snow;
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.Location = new System.Drawing.Point(0, 230);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Reportes.Size = new System.Drawing.Size(320, 80);
            this.btn_Reportes.TabIndex = 8;
            this.btn_Reportes.Text = "  Generar Reportes";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Registros
            // 
            this.btn_Registros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Registros.FlatAppearance.BorderSize = 0;
            this.btn_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registros.ForeColor = System.Drawing.Color.Snow;
            this.btn_Registros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registros.Image")));
            this.btn_Registros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registros.Location = new System.Drawing.Point(0, 150);
            this.btn_Registros.Name = "btn_Registros";
            this.btn_Registros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Registros.Size = new System.Drawing.Size(320, 80);
            this.btn_Registros.TabIndex = 7;
            this.btn_Registros.Text = "  Solicitudes de Registro al Sistema";
            this.btn_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Registros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Registros.UseVisualStyleBackColor = false;
            this.btn_Registros.Click += new System.EventHandler(this.btn_Registros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkGreen;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(320, 150);
            this.panelLogo.TabIndex = 5;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(109, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(0, 16);
            this.lblLogo.TabIndex = 0;
            // 
            // btn_CalculoInteres
            // 
            this.btn_CalculoInteres.Location = new System.Drawing.Point(873, 296);
            this.btn_CalculoInteres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CalculoInteres.Name = "btn_CalculoInteres";
            this.btn_CalculoInteres.Size = new System.Drawing.Size(192, 78);
            this.btn_CalculoInteres.TabIndex = 2;
            this.btn_CalculoInteres.Text = "Calcular Intereses";
            this.btn_CalculoInteres.UseVisualStyleBackColor = true;
            this.btn_CalculoInteres.Click += new System.EventHandler(this.btn_CalculoInteres_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(320, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1112, 150);
            this.panelTitleBar.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(303, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(637, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema de Administración de Inversiones ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1432, 670);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btn_CalculoInteres);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_CalculoInteres;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Interes;
        private System.Windows.Forms.Button btn_Retiros;
        private System.Windows.Forms.Button btn_Depositos;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Registros;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lblLogo;
    }
}

