namespace DeliveryApp.Vista
{
    partial class ConsultaGeneralClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.botonRedondo1 = new DeliveryApp.Recursos.botonRedondo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.dgvCliente);
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Location = new System.Drawing.Point(9, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 633);
            this.panel2.TabIndex = 11;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idC,
            this.nambre,
            this.tele,
            this.Sexoo,
            this.Edad2,
            this.Calle13,
            this.Calle14,
            this.Col,
            this.NuCasa});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCliente.Location = new System.Drawing.Point(0, 0);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1166, 555);
            this.dgvCliente.TabIndex = 3;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.botonRedondo1.ButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.botonRedondo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Sora", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(1003, 578);
            this.botonRedondo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.Size = new System.Drawing.Size(142, 36);
            this.botonRedondo1.TabIndex = 1;
            this.botonRedondo1.Text = "Consulta";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(9, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 13);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clientes";
            // 
            // idC
            // 
            this.idC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idC.HeaderText = "idCliente";
            this.idC.MinimumWidth = 6;
            this.idC.Name = "idC";
            this.idC.ReadOnly = true;
            // 
            // nambre
            // 
            this.nambre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nambre.HeaderText = "Nombre";
            this.nambre.MinimumWidth = 6;
            this.nambre.Name = "nambre";
            this.nambre.ReadOnly = true;
            // 
            // tele
            // 
            this.tele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tele.HeaderText = "Telefono";
            this.tele.MinimumWidth = 6;
            this.tele.Name = "tele";
            this.tele.ReadOnly = true;
            // 
            // Sexoo
            // 
            this.Sexoo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexoo.HeaderText = "Sexo";
            this.Sexoo.MinimumWidth = 6;
            this.Sexoo.Name = "Sexoo";
            this.Sexoo.ReadOnly = true;
            // 
            // Edad2
            // 
            this.Edad2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edad2.HeaderText = "Edad";
            this.Edad2.MinimumWidth = 6;
            this.Edad2.Name = "Edad2";
            this.Edad2.ReadOnly = true;
            // 
            // Calle13
            // 
            this.Calle13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Calle13.HeaderText = "Calle1";
            this.Calle13.MinimumWidth = 6;
            this.Calle13.Name = "Calle13";
            this.Calle13.ReadOnly = true;
            // 
            // Calle14
            // 
            this.Calle14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Calle14.HeaderText = "Calle2";
            this.Calle14.MinimumWidth = 6;
            this.Calle14.Name = "Calle14";
            this.Calle14.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col.HeaderText = "Colonia";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // NuCasa
            // 
            this.NuCasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NuCasa.HeaderText = "Numero de casa";
            this.NuCasa.MinimumWidth = 6;
            this.NuCasa.Name = "NuCasa";
            this.NuCasa.ReadOnly = true;
            // 
            // ConsultaGeneralClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1200, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultaGeneralClientes";
            this.Text = "ConsultaGeneralClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaGeneralClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Recursos.botonRedondo botonRedondo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuCasa;
    }
}