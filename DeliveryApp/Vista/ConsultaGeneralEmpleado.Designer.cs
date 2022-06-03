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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmplea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pussy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            this.btnReporte = new CustomControls.RJControls.RJButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.rjRadioButton1);
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Location = new System.Drawing.Point(18, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 922);
            this.panel2.TabIndex = 14;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 155);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(1624, 767);
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
            this.label1.Font = new System.Drawing.Font("Sora", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados";
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Font = new System.Drawing.Font("Sora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.rjRadioButton1.Location = new System.Drawing.Point(153, 45);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(185, 33);
            this.rjRadioButton1.TabIndex = 6;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "rjRadioButton1";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReporte.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReporte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReporte.BorderRadius = 30;
            this.btnReporte.BorderSize = 0;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Sora", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(884, 45);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(209, 67);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.TextColor = System.Drawing.Color.White;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // ConsultaGeneralEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        private CustomControls.RJControls.RJButton btnReporte;
    }
}