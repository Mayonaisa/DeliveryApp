namespace DeliveryApp
{
    partial class Pantalla_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbxUser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ltbxUser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxUser
            // 
            this.lbxUser.AutoSize = true;
            this.lbxUser.Location = new System.Drawing.Point(56, 25);
            this.lbxUser.Name = "lbxUser";
            this.lbxUser.Size = new System.Drawing.Size(95, 17);
            this.lbxUser.TabIndex = 1;
            this.lbxUser.Text = "Login iniciado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ltbxUser
            // 
            this.ltbxUser.FormattingEnabled = true;
            this.ltbxUser.ItemHeight = 16;
            this.ltbxUser.Location = new System.Drawing.Point(268, 85);
            this.ltbxUser.Name = "ltbxUser";
            this.ltbxUser.Size = new System.Drawing.Size(202, 148);
            this.ltbxUser.TabIndex = 3;
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.ltbxUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbxUser);
            this.Controls.Add(this.button1);
            this.Name = "Pantalla_Principal";
            this.Text = "Pantalla_Principal";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbxUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ltbxUser;
    }
}