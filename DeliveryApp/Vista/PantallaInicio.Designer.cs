namespace DeliveryApp.Vista
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnLogin = new CustomControls.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.btnLogin);
            this.pnlContenedor.Controls.Add(this.label5);
            this.pnlContenedor.Controls.Add(this.label4);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.lblDes);
            this.pnlContenedor.Controls.Add(this.lblRegistrarse);
            this.pnlContenedor.Controls.Add(this.pnlSuperior);
            this.pnlContenedor.Controls.Add(this.lblMensaje);
            this.pnlContenedor.ForeColor = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(688, 166);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(544, 750);
            this.pnlContenedor.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Red;
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Sora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(149, 542);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 62);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Iniciar sesion";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Sora", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(163, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 94);
            this.label5.TabIndex = 20;
            this.label5.Text = "¡Bienvenido\r\nal sistema!\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Sora", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(215, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 47);
            this.label4.TabIndex = 19;
            this.label4.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(143, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 111);
            this.label2.TabIndex = 17;
            this.label2.Text = "Inicia sesión o crea\r\nuna cuenta para \r\nacceder al menu\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDes
            // 
            this.lblDes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblDes.Location = new System.Drawing.Point(151, 359);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(0, 25);
            this.lblDes.TabIndex = 15;
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarse.Font = new System.Drawing.Font("Sora", 9.749999F);
            this.lblRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblRegistrarse.Location = new System.Drawing.Point(185, 629);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(174, 26);
            this.lblRegistrarse.TabIndex = 14;
            this.lblRegistrarse.Text = "O crear una cuenta";
            this.lblRegistrarse.Click += new System.EventHandler(this.label1_Click);
            this.lblRegistrarse.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lblRegistrarse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.panel2);
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(544, 137);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(152, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 46);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sora", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(192, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "DeliveryApp";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(207, 343);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 5;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1920, 1081);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}