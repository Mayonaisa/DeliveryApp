namespace DeliveryApp.Vista
{
    partial class MenuRecepcionista
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxPed = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Recepcionista";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 16);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 509);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel6.Location = new System.Drawing.Point(789, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 141);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel5.Location = new System.Drawing.Point(789, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 141);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel7.Location = new System.Drawing.Point(421, 291);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(259, 141);
            this.panel7.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel4.Location = new System.Drawing.Point(421, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 141);
            this.panel4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.pbxPed);
            this.panel8.Location = new System.Drawing.Point(85, 291);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(259, 141);
            this.panel8.TabIndex = 2;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.panel3.Location = new System.Drawing.Point(85, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 141);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pbxPed
            // 
            this.pbxPed.BackgroundImage = global::DeliveryApp.Properties.Resources.logo4;
            this.pbxPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPed.Location = new System.Drawing.Point(119, 16);
            this.pbxPed.Name = "pbxPed";
            this.pbxPed.Size = new System.Drawing.Size(137, 104);
            this.pbxPed.TabIndex = 5;
            this.pbxPed.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MenuRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1110, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MenuRecepcionista";
            this.Text = "LoginRecepcionista";
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxPed;
        private System.Windows.Forms.Label label2;
    }
}