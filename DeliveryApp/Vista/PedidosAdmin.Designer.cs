﻿namespace DeliveryApp.Vista
{
    partial class PedidosAdmin
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
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
            this.panel2.Controls.Add(this.dgvPedidos);
            this.panel2.Location = new System.Drawing.Point(24, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2165, 1135);
            this.panel2.TabIndex = 8;
            // 
            // rbtodo
            // 
            this.rbtodo.AutoSize = true;
            this.rbtodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbtodo.Location = new System.Drawing.Point(913, 97);
            this.rbtodo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtodo.Name = "rbtodo";
            this.rbtodo.Size = new System.Drawing.Size(181, 29);
            this.rbtodo.TabIndex = 30;
            this.rbtodo.TabStop = true;
            this.rbtodo.Text = "Consulta general";
            this.rbtodo.UseVisualStyleBackColor = true;
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rbPre.Location = new System.Drawing.Point(468, 97);
            this.rbPre.Margin = new System.Windows.Forms.Padding(4);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(122, 29);
            this.rbPre.TabIndex = 33;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Por monto";
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
            this.cbPre.Location = new System.Drawing.Point(468, 140);
            this.cbPre.Margin = new System.Windows.Forms.Padding(4);
            this.cbPre.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbPre.Name = "cbPre";
            this.cbPre.Padding = new System.Windows.Forms.Padding(1);
            this.cbPre.Size = new System.Drawing.Size(397, 44);
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
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(913, 140);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(323, 44);
            this.rjButton1.TabIndex = 31;
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
            this.rbDis.Location = new System.Drawing.Point(8, 97);
            this.rbDis.Margin = new System.Windows.Forms.Padding(4);
            this.rbDis.Name = "rbDis";
            this.rbDis.Size = new System.Drawing.Size(131, 29);
            this.rbDis.TabIndex = 30;
            this.rbDis.TabStop = true;
            this.rbDis.Text = "Por estatus";
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
            this.cbDis.Location = new System.Drawing.Point(8, 140);
            this.cbDis.Margin = new System.Windows.Forms.Padding(4);
            this.cbDis.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbDis.Name = "cbDis";
            this.cbDis.Padding = new System.Windows.Forms.Padding(1);
            this.cbDis.Size = new System.Drawing.Size(397, 44);
            this.cbDis.TabIndex = 29;
            this.cbDis.Texts = "Masculino";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrden,
            this.IdDetalle,
            this.monto,
            this.estatus,
            this.Repa,
            this.Vehi,
            this.Clie,
            this.fechaSolici,
            this.Colo,
            this.NCasa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(8, 200);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1288, 951);
            this.dgvPedidos.TabIndex = 0;
            // 
            // IdOrden
            // 
            this.IdOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdOrden.HeaderText = "idOrden";
            this.IdOrden.MinimumWidth = 6;
            this.IdOrden.Name = "IdOrden";
            this.IdOrden.ReadOnly = true;
            // 
            // IdDetalle
            // 
            this.IdDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdDetalle.HeaderText = "idDetalle";
            this.IdDetalle.MinimumWidth = 6;
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monto.HeaderText = "Monto del pedido";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.HeaderText = "Estatus";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // Repa
            // 
            this.Repa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Repa.HeaderText = "Repartidor";
            this.Repa.MinimumWidth = 6;
            this.Repa.Name = "Repa";
            this.Repa.ReadOnly = true;
            // 
            // Vehi
            // 
            this.Vehi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vehi.HeaderText = "Vehiculo";
            this.Vehi.MinimumWidth = 6;
            this.Vehi.Name = "Vehi";
            this.Vehi.ReadOnly = true;
            // 
            // Clie
            // 
            this.Clie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clie.HeaderText = "Cliente";
            this.Clie.MinimumWidth = 6;
            this.Clie.Name = "Clie";
            this.Clie.ReadOnly = true;
            // 
            // fechaSolici
            // 
            this.fechaSolici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaSolici.HeaderText = "Fecha solicitud";
            this.fechaSolici.MinimumWidth = 6;
            this.fechaSolici.Name = "fechaSolici";
            this.fechaSolici.ReadOnly = true;
            // 
            // Colo
            // 
            this.Colo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colo.HeaderText = "Colonia";
            this.Colo.MinimumWidth = 6;
            this.Colo.Name = "Colo";
            this.Colo.ReadOnly = true;
            // 
            // NCasa
            // 
            this.NCasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NCasa.HeaderText = "Numero de casa";
            this.NCasa.MinimumWidth = 6;
            this.NCasa.Name = "NCasa";
            this.NCasa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catalogo de Pedidos";
            // 
            // PedidosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PedidosAdmin";
            this.Text = "PedidosPendientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PedidosPendientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clie;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCasa;
        private System.Windows.Forms.RadioButton rbPre;
        private CustomControls.RJControls.RJComboBox cbPre;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.RadioButton rbDis;
        private CustomControls.RJControls.RJComboBox cbDis;
        private System.Windows.Forms.RadioButton rbtodo;
    }
}