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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtodo = new System.Windows.Forms.RadioButton();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.cbPre = new CustomControls.RJControls.RJComboBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rbDis = new System.Windows.Forms.RadioButton();
            this.cbDis = new CustomControls.RJControls.RJComboBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmplea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pussy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
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
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Location = new System.Drawing.Point(32, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 1135);
            this.panel2.TabIndex = 14;
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbtodo.Location = new System.Drawing.Point(958, 114);
            this.rbtodo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(181, 29);
            this.rbtodo.TabIndex = 29;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Consulta general";
            this.rbtodo.UseVisualStyleBackColor = true;
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbPre.Location = new System.Drawing.Point(486, 114);
            this.rbPre.Margin = new System.Windows.Forms.Padding(4);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(112, 29);
            this.rbPre.TabIndex = 28;
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
            this.cbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPre.ForeColor = System.Drawing.Color.DimGray;
            this.cbPre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbPre.Items.AddRange(new object[] {
            "Menor a mayor",
            "Mayor a menor"});
            this.cbPre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPre.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPre.Location = new System.Drawing.Point(486, 157);
            this.cbPre.Margin = new System.Windows.Forms.Padding(4);
            this.cbPre.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbPre.Name = "cbPre";
            this.cbPre.Padding = new System.Windows.Forms.Padding(1);
            this.cbPre.Size = new System.Drawing.Size(397, 44);
            this.cbPre.TabIndex = 27;
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
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(958, 157);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(323, 44);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.Text = "Consultar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rbDis
            // 
            this.rbDis.AutoSize = true;
            this.rbDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbDis.Location = new System.Drawing.Point(26, 114);
            this.rbDis.Margin = new System.Windows.Forms.Padding(4);
            this.rbDis.Name = "rbDis";
            this.rbDis.Size = new System.Drawing.Size(110, 29);
            this.rbDis.TabIndex = 25;
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
            this.cbDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDis.ForeColor = System.Drawing.Color.DimGray;
            this.cbDis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbDis.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbDis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDis.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDis.Location = new System.Drawing.Point(26, 157);
            this.cbDis.Margin = new System.Windows.Forms.Padding(4);
            this.cbDis.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbDis.Name = "cbDis";
            this.cbDis.Padding = new System.Windows.Forms.Padding(1);
            this.cbDis.Size = new System.Drawing.Size(397, 44);
            this.cbDis.TabIndex = 24;
            this.cbDis.Texts = "Masculino";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmplea,
            this.nambre,
            this.Telefo,
            this.Sexum,
            this.Edada,
            this.Pussy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.Location = new System.Drawing.Point(26, 218);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(1167, 944);
            this.dgvEmpleados.TabIndex = 4;
            // 
            // idEmplea
            // 
            this.idEmplea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmplea.HeaderText = "idEmpleado";
            this.idEmplea.MinimumWidth = 6;
            this.idEmplea.Name = "idEmplea";
            this.idEmplea.ReadOnly = true;
            // 
            // nambre
            // 
            this.nambre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nambre.HeaderText = "Nombre";
            this.nambre.MinimumWidth = 6;
            this.nambre.Name = "nambre";
            this.nambre.ReadOnly = true;
            // 
            // Telefo
            // 
            this.Telefo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefo.HeaderText = "Telefono";
            this.Telefo.MinimumWidth = 6;
            this.Telefo.Name = "Telefo";
            this.Telefo.ReadOnly = true;
            // 
            // Sexum
            // 
            this.Sexum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexum.HeaderText = "Sexo";
            this.Sexum.MinimumWidth = 6;
            this.Sexum.Name = "Sexum";
            this.Sexum.ReadOnly = true;
            // 
            // Edada
            // 
            this.Edada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edada.HeaderText = "Edad";
            this.Edada.MinimumWidth = 6;
            this.Edada.Name = "Edada";
            this.Edada.ReadOnly = true;
            // 
            // Pussy
            // 
            this.Pussy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pussy.HeaderText = "Posición";
            this.Pussy.MinimumWidth = 6;
            this.Pussy.Name = "Pussy";
            this.Pussy.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Catalogo de Empleados";
            // 
            // ConsultaGeneralEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaGeneralEmpleado";
            this.Text = "ConsultaGeneralEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaGeneralEmpleado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmplea;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pussy;
        private System.Windows.Forms.RadioButton rbPre;
        private CustomControls.RJControls.RJComboBox cbPre;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.RadioButton rbDis;
        private CustomControls.RJControls.RJComboBox cbDis;
        private System.Windows.Forms.RadioButton rbtodo;
    }
}