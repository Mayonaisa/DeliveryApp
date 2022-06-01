namespace DeliveryApp.Vista
{
    partial class CatalogoGeneralVehiculos
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
            this.botonRedondo1 = new DeliveryApp.Recursos.botonRedondo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.idV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.dgvVehiculo);
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Location = new System.Drawing.Point(22, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1554, 779);
            this.panel2.TabIndex = 14;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.botonRedondo1.ButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.botonRedondo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Sora", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(1283, 704);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.Size = new System.Drawing.Size(245, 59);
            this.botonRedondo1.TabIndex = 1;
            this.botonRedondo1.Text = "Consulta";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(22, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 16);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vehiculos";
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idV,
            this.Marca2,
            this.Modelo2,
            this.Color2,
            this.Placoso,
            this.Año2,
            this.Tipo2});
            this.dgvVehiculo.Location = new System.Drawing.Point(3, 3);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.Size = new System.Drawing.Size(1549, 625);
            this.dgvVehiculo.TabIndex = 4;
            // 
            // idV
            // 
            this.idV.HeaderText = "idVehiculo";
            this.idV.MinimumWidth = 6;
            this.idV.Name = "idV";
            this.idV.ReadOnly = true;
            this.idV.Width = 125;
            // 
            // Marca2
            // 
            this.Marca2.HeaderText = "Marca";
            this.Marca2.MinimumWidth = 6;
            this.Marca2.Name = "Marca2";
            this.Marca2.ReadOnly = true;
            this.Marca2.Width = 125;
            // 
            // Modelo2
            // 
            this.Modelo2.HeaderText = "Modelo";
            this.Modelo2.MinimumWidth = 6;
            this.Modelo2.Name = "Modelo2";
            this.Modelo2.ReadOnly = true;
            this.Modelo2.Width = 125;
            // 
            // Color2
            // 
            this.Color2.HeaderText = "Color";
            this.Color2.MinimumWidth = 6;
            this.Color2.Name = "Color2";
            this.Color2.ReadOnly = true;
            this.Color2.Width = 125;
            // 
            // Placoso
            // 
            this.Placoso.HeaderText = "Placa";
            this.Placoso.MinimumWidth = 6;
            this.Placoso.Name = "Placoso";
            this.Placoso.ReadOnly = true;
            this.Placoso.Width = 125;
            // 
            // Año2
            // 
            this.Año2.HeaderText = "Año";
            this.Año2.MinimumWidth = 6;
            this.Año2.Name = "Año2";
            this.Año2.ReadOnly = true;
            this.Año2.Width = 125;
            // 
            // Tipo2
            // 
            this.Tipo2.HeaderText = "Tipo";
            this.Tipo2.MinimumWidth = 6;
            this.Tipo2.Name = "Tipo2";
            this.Tipo2.ReadOnly = true;
            this.Tipo2.Width = 125;
            // 
            // CatalogoGeneralVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1600, 884);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoGeneralVehiculos";
            this.Text = "CatalogoGeneralVehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Recursos.botonRedondo botonRedondo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo2;
    }
}