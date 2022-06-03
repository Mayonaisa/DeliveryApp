﻿namespace DeliveryApp.Vista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCliente.Location = new System.Drawing.Point(0, 128);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1624, 794);
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
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clientes";
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
    }
}