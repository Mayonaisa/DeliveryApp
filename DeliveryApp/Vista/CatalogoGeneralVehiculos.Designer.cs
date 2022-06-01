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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVehiculo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonRedondo1 = new DeliveryApp.Recursos.botonRedondo();
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
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Location = new System.Drawing.Point(22, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1554, 779);
            this.panel2.TabIndex = 14;
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.marc,
            this.Mode,
            this.color,
            this.Pla,
            this.año,
            this.tip});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvVehiculo.Location = new System.Drawing.Point(5, 0);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.Size = new System.Drawing.Size(1549, 625);
            this.dgvVehiculo.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "idVehiculo";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // marc
            // 
            this.marc.HeaderText = "Marca";
            this.marc.MinimumWidth = 6;
            this.marc.Name = "marc";
            this.marc.ReadOnly = true;
            this.marc.Width = 125;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Modelo";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Width = 125;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 125;
            // 
            // Pla
            // 
            this.Pla.HeaderText = "Placa";
            this.Pla.MinimumWidth = 6;
            this.Pla.Name = "Pla";
            this.Pla.ReadOnly = true;
            this.Pla.Width = 125;
            // 
            // año
            // 
            this.año.HeaderText = "Año";
            this.año.MinimumWidth = 6;
            this.año.Name = "año";
            this.año.ReadOnly = true;
            this.año.Width = 125;
            // 
            // tip
            // 
            this.tip.HeaderText = "Tipo";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 125;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvVehiculo;
        private Recursos.botonRedondo botonRedondo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn marc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pla;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
    }
}