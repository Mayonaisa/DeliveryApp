namespace DeliveryApp.Vista
{
    partial class ConsultaGeneralEmpleado
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmplea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pussy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonRedondo1 = new DeliveryApp.Recursos.botonRedondo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Location = new System.Drawing.Point(16, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 633);
            this.panel2.TabIndex = 14;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmplea,
            this.nambre,
            this.Telefo,
            this.Sexum,
            this.Edada,
            this.Pussy});
            this.dgvEmpleados.Location = new System.Drawing.Point(2, 2);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(1163, 508);
            this.dgvEmpleados.TabIndex = 4;
            // 
            // idEmplea
            // 
            this.idEmplea.HeaderText = "idEmpleado";
            this.idEmplea.MinimumWidth = 6;
            this.idEmplea.Name = "idEmplea";
            this.idEmplea.ReadOnly = true;
            this.idEmplea.Width = 125;
            // 
            // nambre
            // 
            this.nambre.HeaderText = "Nombre";
            this.nambre.MinimumWidth = 6;
            this.nambre.Name = "nambre";
            this.nambre.ReadOnly = true;
            this.nambre.Width = 125;
            // 
            // Telefo
            // 
            this.Telefo.HeaderText = "Telefono";
            this.Telefo.MinimumWidth = 6;
            this.Telefo.Name = "Telefo";
            this.Telefo.ReadOnly = true;
            this.Telefo.Width = 125;
            // 
            // Sexum
            // 
            this.Sexum.HeaderText = "Sexo";
            this.Sexum.MinimumWidth = 6;
            this.Sexum.Name = "Sexum";
            this.Sexum.ReadOnly = true;
            this.Sexum.Width = 125;
            // 
            // Edada
            // 
            this.Edada.HeaderText = "Edad";
            this.Edada.MinimumWidth = 6;
            this.Edada.Name = "Edada";
            this.Edada.ReadOnly = true;
            this.Edada.Width = 125;
            // 
            // Pussy
            // 
            this.Pussy.HeaderText = "Posición";
            this.Pussy.MinimumWidth = 6;
            this.Pussy.Name = "Pussy";
            this.Pussy.ReadOnly = true;
            this.Pussy.Width = 125;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.botonRedondo1.ButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.botonRedondo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Sora", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(962, 572);
            this.botonRedondo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.Size = new System.Drawing.Size(184, 48);
            this.botonRedondo1.TabIndex = 1;
            this.botonRedondo1.Text = "Consulta";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(16, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 13);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados";
            // 
            // ConsultaGeneralEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1660, 1011);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultaGeneralEmpleado";
            this.Text = "ConsultaGeneralEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Recursos.botonRedondo botonRedondo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmplea;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pussy;
    }
}