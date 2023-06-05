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
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnCalcularImpuestos = new System.Windows.Forms.Button();
            this.btnActulizarInteres = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Interes = new System.Windows.Forms.Button();
            this.btn_Retiros = new System.Windows.Forms.Button();
            this.btn_Depositos = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Registros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Usuarios);
            this.panelMenu.Controls.Add(this.pnlSubMenu);
            this.panelMenu.Controls.Add(this.btn_CerrarSesion);
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
            this.panelMenu.Size = new System.Drawing.Size(338, 1020);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Usuarios.Image = global::AdminInversiones.Properties.Resources.profile;
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuarios.Location = new System.Drawing.Point(0, 820);
            this.btn_Usuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Usuarios.Size = new System.Drawing.Size(312, 106);
            this.btn_Usuarios.TabIndex = 14;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenu.Controls.Add(this.btnCalcularImpuestos);
            this.pnlSubMenu.Controls.Add(this.btnActulizarInteres);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 705);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(312, 115);
            this.pnlSubMenu.TabIndex = 13;
            // 
            // btnCalcularImpuestos
            // 
            this.btnCalcularImpuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcularImpuestos.FlatAppearance.BorderSize = 0;
            this.btnCalcularImpuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCalcularImpuestos.ForeColor = System.Drawing.Color.White;
            this.btnCalcularImpuestos.Location = new System.Drawing.Point(0, 54);
            this.btnCalcularImpuestos.Name = "btnCalcularImpuestos";
            this.btnCalcularImpuestos.Size = new System.Drawing.Size(312, 54);
            this.btnCalcularImpuestos.TabIndex = 1;
            this.btnCalcularImpuestos.Text = "Calcular Impuestos Mensuales";
            this.btnCalcularImpuestos.UseVisualStyleBackColor = true;
            this.btnCalcularImpuestos.Click += new System.EventHandler(this.btnCalcularIntereses_Click);
            // 
            // btnActulizarInteres
            // 
            this.btnActulizarInteres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActulizarInteres.FlatAppearance.BorderSize = 0;
            this.btnActulizarInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActulizarInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnActulizarInteres.ForeColor = System.Drawing.Color.White;
            this.btnActulizarInteres.Location = new System.Drawing.Point(0, 0);
            this.btnActulizarInteres.Name = "btnActulizarInteres";
            this.btnActulizarInteres.Size = new System.Drawing.Size(312, 54);
            this.btnActulizarInteres.TabIndex = 0;
            this.btnActulizarInteres.Text = "Actualizar Tasas de Interes";
            this.btnActulizarInteres.UseVisualStyleBackColor = true;
            this.btnActulizarInteres.Click += new System.EventHandler(this.btnActulizarInteres_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.AutoSize = true;
            this.btn_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 926);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_CerrarSesion.Size = new System.Drawing.Size(312, 106);
            this.btn_CerrarSesion.TabIndex = 12;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_Interes
            // 
            this.btn_Interes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Interes.FlatAppearance.BorderSize = 0;
            this.btn_Interes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Interes.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Interes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Interes.Image")));
            this.btn_Interes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Interes.Location = new System.Drawing.Point(0, 599);
            this.btn_Interes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Interes.Name = "btn_Interes";
            this.btn_Interes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Interes.Size = new System.Drawing.Size(312, 106);
            this.btn_Interes.TabIndex = 10;
            this.btn_Interes.Text = "Intereses e Impuestos";
            this.btn_Interes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Interes.UseVisualStyleBackColor = true;
            this.btn_Interes.Click += new System.EventHandler(this.btn_Interes_Click_1);
            // 
            // btn_Retiros
            // 
            this.btn_Retiros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Retiros.FlatAppearance.BorderSize = 0;
            this.btn_Retiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retiros.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Retiros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retiros.Image")));
            this.btn_Retiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Retiros.Location = new System.Drawing.Point(0, 493);
            this.btn_Retiros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Retiros.Name = "btn_Retiros";
            this.btn_Retiros.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Retiros.Size = new System.Drawing.Size(312, 106);
            this.btn_Retiros.TabIndex = 9;
            this.btn_Retiros.Text = "Solicitudes de Retiro";
            this.btn_Retiros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Retiros.UseVisualStyleBackColor = true;
            this.btn_Retiros.Click += new System.EventHandler(this.btn_Retiros_Click_1);
            // 
            // btn_Depositos
            // 
            this.btn_Depositos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Depositos.FlatAppearance.BorderSize = 0;
            this.btn_Depositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Depositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depositos.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Depositos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Depositos.Image")));
            this.btn_Depositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Depositos.Location = new System.Drawing.Point(0, 387);
            this.btn_Depositos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Depositos.Name = "btn_Depositos";
            this.btn_Depositos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Depositos.Size = new System.Drawing.Size(312, 106);
            this.btn_Depositos.TabIndex = 8;
            this.btn_Depositos.Text = "Solicitudes de Deposito";
            this.btn_Depositos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Depositos.UseVisualStyleBackColor = true;
            this.btn_Depositos.Click += new System.EventHandler(this.btn_Depositos_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.Location = new System.Drawing.Point(0, 281);
            this.btn_Reportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Reportes.Size = new System.Drawing.Size(312, 106);
            this.btn_Reportes.TabIndex = 7;
            this.btn_Reportes.Text = "Generar Reportes";
            this.btn_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Registros
            // 
            this.btn_Registros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Registros.FlatAppearance.BorderSize = 0;
            this.btn_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registros.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Registros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registros.Image")));
            this.btn_Registros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registros.Location = new System.Drawing.Point(0, 175);
            this.btn_Registros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Registros.Name = "btn_Registros";
            this.btn_Registros.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Registros.Size = new System.Drawing.Size(312, 106);
            this.btn_Registros.TabIndex = 6;
            this.btn_Registros.Text = "Solicitudes de Registro al Sistema";
            this.btn_Registros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Registros.UseVisualStyleBackColor = true;
            this.btn_Registros.Click += new System.EventHandler(this.btn_Registros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(312, 175);
            this.panelLogo.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(338, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1556, 175);
            this.panelTitleBar.TabIndex = 3;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitleBar.Location = new System.Drawing.Point(325, 56);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(1032, 63);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "Sistema de Administracion de Inversiones";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.White;
            this.panelForms.Controls.Add(this.pictureBox1);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(338, 175);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1556, 845);
            this.panelForms.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AdminInversiones.Properties.Resources.Which_Type_of_Investment_Has_the_Highest_Risk_1400x826;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1556, 845);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 1020);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Administracion ANLI";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.pnlSubMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Registros;
        private System.Windows.Forms.Button btn_Interes;
        private System.Windows.Forms.Button btn_Retiros;
        private System.Windows.Forms.Button btn_Depositos;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnCalcularImpuestos;
        private System.Windows.Forms.Button btnActulizarInteres;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

