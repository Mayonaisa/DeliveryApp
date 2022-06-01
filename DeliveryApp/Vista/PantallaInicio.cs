using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Recursos;

namespace DeliveryApp.Vista
{
    
    public partial class PantallaInicio : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        public PantallaInicio(Panel p, CarritoC c)
        {
            contenedor = p;
            Carro = c;
            InitializeComponent();
        }
        public PantallaInicio(Panel p2)
        {
            contenedor = p2;
            InitializeComponent();
        }

        public void Desplegar(Form f)
        {
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }
            contenedor.Width = f.Width;
            contenedor.Height = f.Height;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            contenedor.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUsuario Login = new LoginUsuario(contenedor, Carro);
            Desplegar(Login);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            lblRegistrarse.ForeColor = Color.DarkGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrarse.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegistrarUsuario Registrar = new RegistrarUsuario(contenedor, Carro);
            Desplegar(Registrar);
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 0, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
