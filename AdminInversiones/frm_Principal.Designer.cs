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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Interes = new System.Windows.Forms.Button();
            this.btn_Retiros = new System.Windows.Forms.Button();
            this.btn_Depositos = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Registros = new System.Windows.Forms.Button();
            this.btn_CalculoInteres = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Administracion de Inversiones ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.btn_Interes);
            this.panel2.Controls.Add(this.btn_Retiros);
            this.panel2.Controls.Add(this.btn_Depositos);
            this.panel2.Controls.Add(this.btn_Reportes);
            this.panel2.Controls.Add(this.btn_Registros);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 840);
            this.panel2.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Bisque;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(3, 711);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(277, 122);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "Cerrar Sesion ";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Interes
            // 
            this.btn_Interes.BackColor = System.Drawing.Color.Bisque;
            this.btn_Interes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Interes.Location = new System.Drawing.Point(3, 589);
            this.btn_Interes.Name = "btn_Interes";
            this.btn_Interes.Size = new System.Drawing.Size(277, 122);
            this.btn_Interes.TabIndex = 3;
            this.btn_Interes.Text = "Ingresar Interes ";
            this.btn_Interes.UseVisualStyleBackColor = false;
            this.btn_Interes.Click += new System.EventHandler(this.btn_Interes_Click);
            // 
            // btn_Retiros
            // 
            this.btn_Retiros.BackColor = System.Drawing.Color.Bisque;
            this.btn_Retiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retiros.Location = new System.Drawing.Point(3, 467);
            this.btn_Retiros.Name = "btn_Retiros";
            this.btn_Retiros.Size = new System.Drawing.Size(277, 122);
            this.btn_Retiros.TabIndex = 3;
            this.btn_Retiros.Text = "Solicitudes de Retiro";
            this.btn_Retiros.UseVisualStyleBackColor = false;
            this.btn_Retiros.Click += new System.EventHandler(this.btn_Retiros_Click);
            // 
            // btn_Depositos
            // 
            this.btn_Depositos.BackColor = System.Drawing.Color.Bisque;
            this.btn_Depositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Depositos.Location = new System.Drawing.Point(3, 345);
            this.btn_Depositos.Name = "btn_Depositos";
            this.btn_Depositos.Size = new System.Drawing.Size(277, 122);
            this.btn_Depositos.TabIndex = 3;
            this.btn_Depositos.Text = "Solicitudes de Deposito";
            this.btn_Depositos.UseVisualStyleBackColor = false;
            this.btn_Depositos.Click += new System.EventHandler(this.btn_Depositos_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.Bisque;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Location = new System.Drawing.Point(3, 223);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(277, 122);
            this.btn_Reportes.TabIndex = 3;
            this.btn_Reportes.Text = "Generar Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Registros
            // 
            this.btn_Registros.BackColor = System.Drawing.Color.Bisque;
            this.btn_Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registros.Location = new System.Drawing.Point(3, 101);
            this.btn_Registros.Name = "btn_Registros";
            this.btn_Registros.Size = new System.Drawing.Size(277, 122);
            this.btn_Registros.TabIndex = 2;
            this.btn_Registros.Text = "Solicitudes de Registro al Sistema";
            this.btn_Registros.UseVisualStyleBackColor = false;
            this.btn_Registros.Click += new System.EventHandler(this.btn_Registros_Click);
            // 
            // btn_CalculoInteres
            // 
            this.btn_CalculoInteres.Location = new System.Drawing.Point(317, 125);
            this.btn_CalculoInteres.Name = "btn_CalculoInteres";
            this.btn_CalculoInteres.Size = new System.Drawing.Size(216, 98);
            this.btn_CalculoInteres.TabIndex = 2;
            this.btn_CalculoInteres.Text = "Calcular Intereses";
            this.btn_CalculoInteres.UseVisualStyleBackColor = true;
            this.btn_CalculoInteres.Click += new System.EventHandler(this.btn_CalculoInteres_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1545, 837);
            this.Controls.Add(this.btn_CalculoInteres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Interes;
        private System.Windows.Forms.Button btn_Retiros;
        private System.Windows.Forms.Button btn_Depositos;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Registros;
        private System.Windows.Forms.Button btn_CalculoInteres;
    }
}

