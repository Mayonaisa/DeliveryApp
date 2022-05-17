using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Recursos
{
    class producto : Panel
    {
        private PictureBox Imagen;
        private Label lblprincipal;
        private Label lblmonto;
        private botonRedondo BRcantidad;
        private botonRedondo BRprincipal;
        private botonRedondo BRsecundario;
        private botonRedondo BRmas;
        private botonRedondo BRmenos;

        public producto(string imagen, string producto, string monto, int x, int y)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryApp.Properties.Resources));

            this.Size = new System.Drawing.Size(801, 156);
            this.Location = new Point(x, y);
            this.BorderStyle = BorderStyle.FixedSingle;

            Imagen = new PictureBox();
            this.Controls.Add(this.Imagen);
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject(imagen)));
            this.Imagen.Location = new System.Drawing.Point(3, 3);
            this.Imagen.Name = "PictureBox1";
            this.Imagen.Size = new System.Drawing.Size(148, 148);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 34;
            this.Imagen.TabStop = false;

            lblprincipal = new Label();
            this.Controls.Add(this.lblprincipal);
            this.lblprincipal.AutoSize = true;
            this.lblprincipal.Name = "lblnombre";
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipal.ForeColor = Color.Black;
            this.lblprincipal.Location = new System.Drawing.Point(182, 26);
            this.lblprincipal.Size = new System.Drawing.Size(219, 29);
            this.lblprincipal.Text = producto;

            lblmonto = new Label();
            this.Controls.Add(this.lblmonto);
            this.lblmonto.AutoSize = true;
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = Color.FromArgb(0, 184, 49);
            this.lblmonto.Location = new System.Drawing.Point(182, 67);
            this.lblmonto.Size = new System.Drawing.Size(219, 29);
            this.lblmonto.Text = monto;

            BRcantidad = new botonRedondo();
            this.Controls.Add(this.BRcantidad);
            this.BRcantidad.BackColor = Color.FromArgb(236, 236, 236);
            this.BRcantidad.FlatStyle = FlatStyle.Flat;
            this.BRcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRcantidad.Location = new Point(496, 18);
            this.BRcantidad.Size = new System.Drawing.Size(43, 46);
            this.BRcantidad.Text = "0";
            this.BRcantidad.FlatAppearance.BorderSize = 0;

            BRmenos = new botonRedondo();
            BRmenos.Click += new System.EventHandler(btn_menos_click);
            this.Controls.Add(this.BRmenos);
            this.BRmenos.BackColor = Color.White;
            this.BRmenos.FlatStyle = FlatStyle.Flat;
            this.BRmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRmenos.Location = new Point(447, 18);
            this.BRmenos.Size = new System.Drawing.Size(43, 46);
            this.BRmenos.Text = "-";
            this.BRmenos.FlatAppearance.BorderSize = 0;

            BRmas = new botonRedondo();
            BRmas.Click += new System.EventHandler(btn_mas_click);
            this.Controls.Add(this.BRmas);
            this.BRmas.BackColor = Color.White;
            this.BRmas.FlatStyle = FlatStyle.Flat;
            this.BRmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRmas.Location = new Point(544, 18);
            this.BRmas.Size = new System.Drawing.Size(43, 46);
            this.BRmas.Text = "+";
            this.BRmas.FlatAppearance.BorderSize = 0;

            BRprincipal = new botonRedondo();
            BRprincipal.Click += new System.EventHandler(btn_agregar_click);
            this.Controls.Add(this.BRprincipal);
            this.BRprincipal.BackColor = Color.FromArgb(255, 36, 36);
            this.BRprincipal.FlatStyle = FlatStyle.Flat;
            this.BRprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRprincipal.ForeColor = Color.White;
            this.BRprincipal.Location = new Point(593, 18);
            this.BRprincipal.Size = new System.Drawing.Size(189, 46);
            this.BRprincipal.Text = "Agregar";
            this.BRprincipal.FlatAppearance.BorderSize = 0;

            BRsecundario = new botonRedondo();
            BRsecundario.Click += new System.EventHandler(btn_consultar_click);
            this.Controls.Add(this.BRsecundario);
            this.BRsecundario.BackColor = Color.White;
            this.BRsecundario.FlatStyle = FlatStyle.Flat;
            this.BRsecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRsecundario.ForeColor = Color.Black;
            this.BRsecundario.Location = new Point(593, 81);
            this.BRsecundario.Size = new System.Drawing.Size(189, 46);
            this.BRsecundario.Text = "Consultar";
            this.BRsecundario.FlatAppearance.BorderSize = 0;

        }

        public producto(string texto, string monto, int x, int y)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryApp.Properties.Resources));

            this.Size = new System.Drawing.Size(801, 82);
            this.Location = new Point(x, y);
            this.BorderStyle = BorderStyle.FixedSingle;

            lblprincipal = new Label();
            this.Controls.Add(this.lblprincipal);
            this.lblprincipal.AutoSize = true;
            this.lblprincipal.Name = "lblnombre";
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipal.ForeColor = Color.Black;
            this.lblprincipal.Location = new System.Drawing.Point(17, 26);
            this.lblprincipal.Size = new System.Drawing.Size(219, 29);
            this.lblprincipal.Text = texto;

            lblmonto = new Label();
            this.Controls.Add(this.lblmonto);
            this.lblmonto.AutoSize = true;
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = Color.FromArgb(0, 184, 49);
            this.lblmonto.Location = new System.Drawing.Point(308, 26);
            this.lblmonto.Size = new System.Drawing.Size(219, 29);
            this.lblmonto.Text = monto;

            BRcantidad = new botonRedondo();
            this.Controls.Add(this.BRcantidad);
            this.BRcantidad.BackColor = Color.FromArgb(236, 236, 236);
            this.BRcantidad.FlatStyle = FlatStyle.Flat;
            this.BRcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRcantidad.Location = new Point(234, 18);
            this.BRcantidad.Size = new System.Drawing.Size(43, 46);
            this.BRcantidad.Text = "0";
            this.BRcantidad.FlatAppearance.BorderSize = 0;

            BRprincipal = new botonRedondo();
            BRprincipal.Click += new System.EventHandler(btn_principal_click);
            this.Controls.Add(this.BRprincipal);
            this.BRprincipal.BackColor = Color.FromArgb(255, 36, 36);
            this.BRprincipal.FlatStyle = FlatStyle.Flat;
            this.BRprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRprincipal.ForeColor = Color.White;
            this.BRprincipal.Location = new Point(593, 18);
            this.BRprincipal.Size = new System.Drawing.Size(189, 46);
            this.BRprincipal.Text = "Agregar";
            this.BRprincipal.FlatAppearance.BorderSize = 0;
        }

        private void btn_menos_click(object sender, EventArgs e)
        {
            if(true)
            {
                //bruh nibba text here
            }
        }

        private void btn_mas_click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void btn_agregar_click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void btn_consultar_click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void btn_principal_click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
