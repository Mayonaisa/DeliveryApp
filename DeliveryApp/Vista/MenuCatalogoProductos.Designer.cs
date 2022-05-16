namespace DeliveryApp.Vista
{
    partial class MenuCatalogoProductos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.botonRedondo1);
            this.panel2.Controls.Add(this.dgvPedidos);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 565);
            this.panel2.TabIndex = 11;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.botonRedondo1.ButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonRedondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(871, 511);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.botonRedondo1.OnHoverButtonColor = System.Drawing.Color.Gainsboro;
            this.botonRedondo1.OnHoverTextColor = System.Drawing.Color.White;
            this.botonRedondo1.Size = new System.Drawing.Size(203, 51);
            this.botonRedondo1.TabIndex = 1;
            this.botonRedondo1.Text = "Consulta";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.Ciu,
            this.C1,
            this.C2,
            this.Colo,
            this.NCasa,
            this.Aceptar});
            this.dgvPedidos.Location = new System.Drawing.Point(5, -1);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(1078, 476);
            this.dgvPedidos.TabIndex = 0;
            // 
            // IdOrden
            // 
            this.IdOrden.HeaderText = "idOrden";
            this.IdOrden.MinimumWidth = 6;
            this.IdOrden.Name = "IdOrden";
            this.IdOrden.ReadOnly = true;
            this.IdOrden.Width = 125;
            // 
            // IdDetalle
            // 
            this.IdDetalle.HeaderText = "idDetalle";
            this.IdDetalle.MinimumWidth = 6;
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            this.IdDetalle.Width = 125;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto del pedido";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 125;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 125;
            // 
            // Repa
            // 
            this.Repa.HeaderText = "Repartidor";
            this.Repa.MinimumWidth = 6;
            this.Repa.Name = "Repa";
            this.Repa.ReadOnly = true;
            this.Repa.Width = 125;
            // 
            // Vehi
            // 
            this.Vehi.HeaderText = "Vehiculo";
            this.Vehi.MinimumWidth = 6;
            this.Vehi.Name = "Vehi";
            this.Vehi.ReadOnly = true;
            this.Vehi.Width = 125;
            // 
            // Clie
            // 
            this.Clie.HeaderText = "Cliente";
            this.Clie.MinimumWidth = 6;
            this.Clie.Name = "Clie";
            this.Clie.ReadOnly = true;
            this.Clie.Width = 125;
            // 
            // fechaSolici
            // 
            this.fechaSolici.HeaderText = "Fecha solicitud";
            this.fechaSolici.MinimumWidth = 6;
            this.fechaSolici.Name = "fechaSolici";
            this.fechaSolici.ReadOnly = true;
            this.fechaSolici.Width = 125;
            // 
            // Ciu
            // 
            this.Ciu.HeaderText = "Ciudad";
            this.Ciu.MinimumWidth = 6;
            this.Ciu.Name = "Ciu";
            this.Ciu.ReadOnly = true;
            this.Ciu.Width = 125;
            // 
            // C1
            // 
            this.C1.HeaderText = "Calle1";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 125;
            // 
            // C2
            // 
            this.C2.HeaderText = "Calle2";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 125;
            // 
            // Colo
            // 
            this.Colo.HeaderText = "Colonia";
            this.Colo.MinimumWidth = 6;
            this.Colo.Name = "Colo";
            this.Colo.ReadOnly = true;
            this.Colo.Width = 125;
            // 
            // NCasa
            // 
            this.NCasa.HeaderText = "Numero de casa";
            this.NCasa.MinimumWidth = 6;
            this.NCasa.Name = "NCasa";
            this.NCasa.ReadOnly = true;
            this.NCasa.Width = 125;
            // 
            // Aceptar
            // 
            this.Aceptar.HeaderText = "";
            this.Aceptar.MinimumWidth = 6;
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 16);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Productos";
            // 
            // MenuCatalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCatalogoProductos";
            this.Text = "MenuCatalogoProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Recursos.botonRedondo botonRedondo1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clie;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}