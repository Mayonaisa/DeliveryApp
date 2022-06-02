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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.idV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.dgvVehiculo);
            this.panel2.Location = new System.Drawing.Point(21, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1555, 779);
            this.panel2.TabIndex = 14;
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.dgvVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idV,
            this.Marca2,
            this.Modelo2,
            this.Color2,
            this.Placoso,
            this.Año2,
            this.Tipo2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVehiculo.Location = new System.Drawing.Point(0, 0);
            this.dgvVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVehiculo.MultiSelect = false;
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersVisible = false;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculo.Size = new System.Drawing.Size(1555, 677);
            this.dgvVehiculo.TabIndex = 4;
            this.dgvVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellClick);
            // 
            // idV
            // 
            this.idV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idV.HeaderText = "idVehiculo";
            this.idV.MinimumWidth = 6;
            this.idV.Name = "idV";
            this.idV.ReadOnly = true;
            // 
            // Marca2
            // 
            this.Marca2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca2.HeaderText = "Marca";
            this.Marca2.MinimumWidth = 6;
            this.Marca2.Name = "Marca2";
            this.Marca2.ReadOnly = true;
            // 
            // Modelo2
            // 
            this.Modelo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo2.HeaderText = "Modelo";
            this.Modelo2.MinimumWidth = 6;
            this.Modelo2.Name = "Modelo2";
            this.Modelo2.ReadOnly = true;
            // 
            // Color2
            // 
            this.Color2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color2.HeaderText = "Color";
            this.Color2.MinimumWidth = 6;
            this.Color2.Name = "Color2";
            this.Color2.ReadOnly = true;
            // 
            // Placoso
            // 
            this.Placoso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Placoso.HeaderText = "Placa";
            this.Placoso.MinimumWidth = 6;
            this.Placoso.Name = "Placoso";
            this.Placoso.ReadOnly = true;
            // 
            // Año2
            // 
            this.Año2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Año2.HeaderText = "Año";
            this.Año2.MinimumWidth = 6;
            this.Año2.Name = "Año2";
            this.Año2.ReadOnly = true;
            // 
            // Tipo2
            // 
            this.Tipo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo2.HeaderText = "Tipo";
            this.Tipo2.MinimumWidth = 6;
            this.Tipo2.Name = "Tipo2";
            this.Tipo2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(21, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 16);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vehiculos";
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogoGeneralVehiculos";
            this.Text = "CatalogoGeneralVehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CatalogoGeneralVehiculos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
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