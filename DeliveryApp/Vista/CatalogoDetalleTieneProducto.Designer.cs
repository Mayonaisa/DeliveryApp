namespace DeliveryApp.Vista
{
    partial class CatalogoDetalleTieneProducto
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
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.TabIndex = 14;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.botonRedondo1.ButtonColor = System.Drawing.Color.Transparent;
            this.botonRedondo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.botonRedondo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
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
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.cant,
            this.Producto});
            this.dgvPedidos.Location = new System.Drawing.Point(215, -1);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(641, 476);
            this.dgvPedidos.TabIndex = 0;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "idDetalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 125;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.MinimumWidth = 6;
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "idProducto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 16);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Productos";
            // 
            // CatalogoDetalleTieneProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoDetalleTieneProducto";
            this.Text = "CatalogoDetalleTieneProducto";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
    }
}