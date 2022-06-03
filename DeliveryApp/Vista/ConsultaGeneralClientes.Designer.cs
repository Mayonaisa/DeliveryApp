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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.idC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.cbPre = new CustomControls.RJControls.RJComboBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rbDis = new System.Windows.Forms.RadioButton();
            this.cbDis = new CustomControls.RJControls.RJComboBox();
            this.rbtodo = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.rbtodo);
            this.panel2.Controls.Add(this.rbPre);
            this.panel2.Controls.Add(this.cbPre);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.rbDis);
            this.panel2.Controls.Add(this.cbDis);
            this.panel2.Controls.Add(this.dgvCliente);
            this.panel2.Location = new System.Drawing.Point(18, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 922);
            this.panel2.TabIndex = 11;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCliente.Location = new System.Drawing.Point(0, 150);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1624, 772);
            this.dgvCliente.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sora", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Catalogo de  Clientes";
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Font = new System.Drawing.Font("Sora", 12F);
            this.rbPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbPre.Location = new System.Drawing.Point(391, 36);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(103, 29);
            this.rbPre.TabIndex = 33;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Por edad";
            this.rbPre.UseVisualStyleBackColor = true;
            // 
            // cbPre
            // 
            this.cbPre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbPre.BorderSize = 1;
            this.cbPre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPre.Font = new System.Drawing.Font("Sora", 12F);
            this.cbPre.ForeColor = System.Drawing.Color.DimGray;
            this.cbPre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbPre.Items.AddRange(new object[] {
            "Menor a mayor",
            "Mayor a menor"});
            this.cbPre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPre.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPre.Location = new System.Drawing.Point(391, 71);
            this.cbPre.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPre.Name = "cbPre";
            this.cbPre.Padding = new System.Windows.Forms.Padding(1);
            this.cbPre.Size = new System.Drawing.Size(298, 36);
            this.cbPre.TabIndex = 32;
            this.cbPre.Texts = "Menor a mayor";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Sora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1337, 71);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(242, 36);
            this.rjButton1.TabIndex = 31;
            this.rjButton1.Text = "Consultar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rbDis
            // 
            this.rbDis.AutoSize = true;
            this.rbDis.Font = new System.Drawing.Font("Sora", 12F);
            this.rbDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbDis.Location = new System.Drawing.Point(46, 36);
            this.rbDis.Name = "rbDis";
            this.rbDis.Size = new System.Drawing.Size(101, 29);
            this.rbDis.TabIndex = 30;
            this.rbDis.TabStop = true;
            this.rbDis.Text = "Por sexo";
            this.rbDis.UseVisualStyleBackColor = true;
            // 
            // cbDis
            // 
            this.cbDis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbDis.BorderSize = 1;
            this.cbDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDis.Font = new System.Drawing.Font("Sora", 12F);
            this.cbDis.ForeColor = System.Drawing.Color.DimGray;
            this.cbDis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbDis.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbDis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDis.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDis.Location = new System.Drawing.Point(46, 71);
            this.cbDis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDis.Name = "cbDis";
            this.cbDis.Padding = new System.Windows.Forms.Padding(1);
            this.cbDis.Size = new System.Drawing.Size(298, 36);
            this.cbDis.TabIndex = 29;
            this.cbDis.Texts = "Masculino";
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.Font = new System.Drawing.Font("Sora", 12F);
            this.rbtodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbtodo.Location = new System.Drawing.Point(1337, 36);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(170, 29);
            this.rbtodo.TabIndex = 34;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Consulta general";
            this.rbtodo.UseVisualStyleBackColor = true;
            // 
            // ConsultaGeneralClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1660, 1011);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaGeneralClientes";
            this.Text = "ConsultaGeneralClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaGeneralClientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.RadioButton rbPre;
        private CustomControls.RJControls.RJComboBox cbPre;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.RadioButton rbDis;
        private CustomControls.RJControls.RJComboBox cbDis;
        private System.Windows.Forms.RadioButton rbtodo;
    }
}