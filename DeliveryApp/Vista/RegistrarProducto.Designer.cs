namespace DeliveryApp.Vista
{
    partial class RegistrarProducto
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
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btnVolver = new CustomControls.RJControls.RJButton();
            this.s = new System.Windows.Forms.Panel();
            this.txtNombre = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrecio = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDis = new CustomControls.RJControls.RJComboBox();
            this.panel2.SuspendLayout();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.s);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(18, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 922);
            this.panel2.TabIndex = 19;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1461, 857);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(146, 46);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Registrar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SlateGray;
            this.btnVolver.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.BorderRadius = 20;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(16, 857);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(146, 46);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.s.Controls.Add(this.cbxDis);
            this.s.Controls.Add(this.txtNombre);
            this.s.Controls.Add(this.label5);
            this.s.Controls.Add(this.tbxPrecio);
            this.s.Controls.Add(this.label3);
            this.s.Controls.Add(this.label2);
            this.s.Dock = System.Windows.Forms.DockStyle.Top;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Margin = new System.Windows.Forms.Padding(2);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(1624, 838);
            this.s.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Sora", 11.25F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(663, 335);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(302, 38);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(659, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.Color.White;
            this.tbxPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbxPrecio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbxPrecio.BorderRadius = 0;
            this.tbxPrecio.BorderSize = 2;
            this.tbxPrecio.Font = new System.Drawing.Font("Sora", 11.25F);
            this.tbxPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPrecio.Location = new System.Drawing.Point(663, 414);
            this.tbxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrecio.Multiline = false;
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPrecio.PasswordChar = false;
            this.tbxPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPrecio.PlaceholderText = "";
            this.tbxPrecio.Size = new System.Drawing.Size(302, 38);
            this.tbxPrecio.TabIndex = 19;
            this.tbxPrecio.Texts = "";
            this.tbxPrecio.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(659, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(661, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Disponibilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sora", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registrar producto";
            // 
            // cbxDis
            // 
            this.cbxDis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxDis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbxDis.BorderSize = 2;
            this.cbxDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxDis.ForeColor = System.Drawing.Color.DimGray;
            this.cbxDis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbxDis.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbxDis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxDis.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxDis.Location = new System.Drawing.Point(664, 499);
            this.cbxDis.MinimumSize = new System.Drawing.Size(200, 38);
            this.cbxDis.Name = "cbxDis";
            this.cbxDis.Padding = new System.Windows.Forms.Padding(2);
            this.cbxDis.Size = new System.Drawing.Size(301, 38);
            this.cbxDis.TabIndex = 28;
            this.cbxDis.Texts = "Sí";
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1660, 1011);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProducto";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.MenuProductos_Load);
            this.panel2.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btnVolver;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox tbxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJComboBox cbxDis;
    }
}