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
            this.btn_Interes = new System.Windows.Forms.Button();
            this.btn_Retiros = new System.Windows.Forms.Button();
            this.btn_Depositos = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Registros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_CalculoInteres = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.panelMenu.Size = new System.Drawing.Size(252, 670);
            this.panelMenu.TabIndex = 1;
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
            this.btn_Interes.Location = new System.Drawing.Point(0, 432);
            this.btn_Interes.Name = "btn_Interes";
            this.btn_Interes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Interes.Size = new System.Drawing.Size(252, 80);
            this.btn_Interes.TabIndex = 10;
            this.btn_Interes.Text = "Ingresar Interes ";
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
            this.btn_Retiros.Location = new System.Drawing.Point(0, 352);
            this.btn_Retiros.Name = "btn_Retiros";
            this.btn_Retiros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Retiros.Size = new System.Drawing.Size(252, 80);
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
            this.btn_Depositos.Location = new System.Drawing.Point(0, 272);
            this.btn_Depositos.Name = "btn_Depositos";
            this.btn_Depositos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Depositos.Size = new System.Drawing.Size(252, 80);
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
            this.btn_Reportes.Location = new System.Drawing.Point(0, 192);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Reportes.Size = new System.Drawing.Size(252, 80);
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
            this.btn_Registros.Location = new System.Drawing.Point(0, 112);
            this.btn_Registros.Name = "btn_Registros";
            this.btn_Registros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Registros.Size = new System.Drawing.Size(252, 80);
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
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(252, 112);
            this.panelLogo.TabIndex = 5;
            // 
            // btn_CalculoInteres
            // 
            this.btn_CalculoInteres.Location = new System.Drawing.Point(614, 227);
            this.btn_CalculoInteres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CalculoInteres.Name = "btn_CalculoInteres";
            this.btn_CalculoInteres.Size = new System.Drawing.Size(192, 78);
            this.btn_CalculoInteres.TabIndex = 2;
            this.btn_CalculoInteres.Text = "Calcular Intereses";
            this.btn_CalculoInteres.UseVisualStyleBackColor = true;
            this.btn_CalculoInteres.Click += new System.EventHandler(this.btn_CalculoInteres_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 512);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_CerrarSesion.Size = new System.Drawing.Size(252, 80);
            this.btn_CerrarSesion.TabIndex = 12;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(252, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1121, 112);
            this.panelTitleBar.TabIndex = 3;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitleBar.Location = new System.Drawing.Point(357, 44);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(501, 29);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "Sistema de Administracion de Inversiones";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 670);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btn_CalculoInteres);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Principal";
            this.Text = "Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_CalculoInteres;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Registros;
        private System.Windows.Forms.Button btn_Interes;
        private System.Windows.Forms.Button btn_Retiros;
        private System.Windows.Forms.Button btn_Depositos;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
    }
}

