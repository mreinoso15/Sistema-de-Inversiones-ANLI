namespace AdminInversiones.Forms
{
    partial class frm_DepositosRetiros
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
            this.dtgRetiros = new System.Windows.Forms.DataGridView();
            this.dtgDepositos = new System.Windows.Forms.DataGridView();
            this.dtgDepositosCalculados = new System.Windows.Forms.DataGridView();
            this.cmb_Socios = new System.Windows.Forms.ComboBox();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.lblDepositosCalculados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dtpFechaDR = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRetiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepositosCalculados)).BeginInit();
            this.grpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgRetiros
            // 
            this.dtgRetiros.AllowUserToAddRows = false;
            this.dtgRetiros.AllowUserToDeleteRows = false;
            this.dtgRetiros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRetiros.Location = new System.Drawing.Point(877, 39);
            this.dtgRetiros.Name = "dtgRetiros";
            this.dtgRetiros.ReadOnly = true;
            this.dtgRetiros.RowHeadersWidth = 62;
            this.dtgRetiros.RowTemplate.Height = 28;
            this.dtgRetiros.Size = new System.Drawing.Size(482, 724);
            this.dtgRetiros.TabIndex = 1;
            // 
            // dtgDepositos
            // 
            this.dtgDepositos.AllowUserToAddRows = false;
            this.dtgDepositos.AllowUserToDeleteRows = false;
            this.dtgDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDepositos.Location = new System.Drawing.Point(347, 37);
            this.dtgDepositos.Name = "dtgDepositos";
            this.dtgDepositos.ReadOnly = true;
            this.dtgDepositos.RowHeadersWidth = 62;
            this.dtgDepositos.RowTemplate.Height = 28;
            this.dtgDepositos.Size = new System.Drawing.Size(497, 323);
            this.dtgDepositos.TabIndex = 2;
            // 
            // dtgDepositosCalculados
            // 
            this.dtgDepositosCalculados.AllowUserToAddRows = false;
            this.dtgDepositosCalculados.AllowUserToDeleteRows = false;
            this.dtgDepositosCalculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDepositosCalculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDepositosCalculados.Location = new System.Drawing.Point(347, 401);
            this.dtgDepositosCalculados.Name = "dtgDepositosCalculados";
            this.dtgDepositosCalculados.ReadOnly = true;
            this.dtgDepositosCalculados.RowHeadersWidth = 62;
            this.dtgDepositosCalculados.RowTemplate.Height = 28;
            this.dtgDepositosCalculados.Size = new System.Drawing.Size(497, 362);
            this.dtgDepositosCalculados.TabIndex = 3;
            // 
            // cmb_Socios
            // 
            this.cmb_Socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Socios.FormattingEnabled = true;
            this.cmb_Socios.Location = new System.Drawing.Point(15, 117);
            this.cmb_Socios.Name = "cmb_Socios";
            this.cmb_Socios.Size = new System.Drawing.Size(269, 28);
            this.cmb_Socios.TabIndex = 7;
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositos.Location = new System.Drawing.Point(342, 9);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(108, 25);
            this.lblDepositos.TabIndex = 8;
            this.lblDepositos.Text = "Depositos";
            // 
            // lblDepositosCalculados
            // 
            this.lblDepositosCalculados.AutoSize = true;
            this.lblDepositosCalculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositosCalculados.Location = new System.Drawing.Point(342, 373);
            this.lblDepositosCalculados.Name = "lblDepositosCalculados";
            this.lblDepositosCalculados.Size = new System.Drawing.Size(222, 25);
            this.lblDepositosCalculados.TabIndex = 9;
            this.lblDepositosCalculados.Text = "Depositos Calculados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Retiros";
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUser.Location = new System.Drawing.Point(17, 57);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(210, 25);
            this.lblSelectUser.TabIndex = 11;
            this.lblSelectUser.Text = "Seleccionar usuario:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::AdminInversiones.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(22, 265);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(234, 55);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(17, 27);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(261, 25);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar depositos y retiros";
            // 
            // dtpFechaDR
            // 
            this.dtpFechaDR.Location = new System.Drawing.Point(22, 215);
            this.dtpFechaDR.Name = "dtpFechaDR";
            this.dtpFechaDR.Size = new System.Drawing.Size(262, 26);
            this.dtpFechaDR.TabIndex = 17;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(17, 148);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(192, 50);
            this.lblSelectDate.TabIndex = 18;
            this.lblSelectDate.Text = "Seleccionar fecha:\r\n(Mes y año)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "(Buscar por # de usuario)";
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.lblBuscar);
            this.grpControles.Controls.Add(this.lblSelectDate);
            this.grpControles.Controls.Add(this.label2);
            this.grpControles.Controls.Add(this.dtpFechaDR);
            this.grpControles.Controls.Add(this.cmb_Socios);
            this.grpControles.Controls.Add(this.lblSelectUser);
            this.grpControles.Controls.Add(this.btnBuscar);
            this.grpControles.Location = new System.Drawing.Point(12, 12);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(324, 348);
            this.grpControles.TabIndex = 20;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // frm_DepositosRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 789);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDepositosCalculados);
            this.Controls.Add(this.lblDepositos);
            this.Controls.Add(this.dtgDepositosCalculados);
            this.Controls.Add(this.dtgDepositos);
            this.Controls.Add(this.dtgRetiros);
            this.Name = "frm_DepositosRetiros";
            this.Text = "frm_DepositosRetiros";
            this.Load += new System.EventHandler(this.frm_DepositosRetiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRetiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepositosCalculados)).EndInit();
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRetiros;
        private System.Windows.Forms.DataGridView dtgDepositos;
        private System.Windows.Forms.DataGridView dtgDepositosCalculados;
        private System.Windows.Forms.ComboBox cmb_Socios;
        private System.Windows.Forms.Label lblDepositos;
        private System.Windows.Forms.Label lblDepositosCalculados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDR;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpControles;
    }
}