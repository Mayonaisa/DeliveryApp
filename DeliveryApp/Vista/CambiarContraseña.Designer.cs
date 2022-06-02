namespace DeliveryApp.Vista
{
    partial class CambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnEnviar = new CustomControls.RJControls.RJButton();
            this.tbxCorreo = new CustomControls.RJControls.RJTextBox();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.btnEnviar);
            this.pnlContenedor.Controls.Add(this.tbxCorreo);
            this.pnlContenedor.Controls.Add(this.lblRegresar);
            this.pnlContenedor.Controls.Add(this.label4);
            this.pnlContenedor.Controls.Add(this.pnlSuperior);
            this.pnlContenedor.Controls.Add(this.lblMensaje);
            this.pnlContenedor.ForeColor = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(443, 41);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(544, 750);
            this.pnlContenedor.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Red;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.Red;
            this.btnEnviar.BorderColor = System.Drawing.Color.White;
            this.btnEnviar.BorderRadius = 20;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Sora", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(149, 545);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(245, 62);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbxCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbxCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbxCorreo.BorderRadius = 10;
            this.tbxCorreo.BorderSize = 2;
            this.tbxCorreo.Font = new System.Drawing.Font("Sora", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tbxCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCorreo.Location = new System.Drawing.Point(105, 293);
            this.tbxCorreo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxCorreo.Multiline = false;
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbxCorreo.PasswordChar = false;
            this.tbxCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxCorreo.PlaceholderText = "Correo electronico";
            this.tbxCorreo.Size = new System.Drawing.Size(333, 45);
            this.tbxCorreo.TabIndex = 27;
            this.tbxCorreo.Texts = "";
            this.tbxCorreo.UnderlinedStyle = false;
            // 
            // lblRegresar
            // 
            this.lblRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Sora", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblRegresar.Location = new System.Drawing.Point(192, 633);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(158, 26);
            this.lblRegresar.TabIndex = 14;
            this.lblRegresar.Text = "Regresar al inicio";
            this.lblRegresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Sora", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(136, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enviar contraseña";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuperior.Controls.Add(this.panel2);
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 1);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(543, 137);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(151, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 46);
            this.panel2.TabIndex = 8;
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
            this.label3.Location = new System.Drawing.Point(191, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "DeliveryApp";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(160, 433);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 5;
            // 
            // pbxFondo
            // 
            this.pbxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxFondo.Image = global::DeliveryApp.Properties.Resources.delicious_food_frame_top_view;
            this.pbxFondo.Location = new System.Drawing.Point(0, 0);
            this.pbxFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(1429, 831);
            this.pbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFondo.TabIndex = 8;
            this.pbxFondo.TabStop = false;
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 831);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pbxFondo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CambiarContraseña";
            this.Text = "CambiarContraseña";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbxFondo;
        private CustomControls.RJControls.RJButton btnEnviar;
        private CustomControls.RJControls.RJTextBox tbxCorreo;
    }
}