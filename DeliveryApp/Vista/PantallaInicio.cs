using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Vista
{
    
    public partial class PantallaInicio : Form
    {
        Panel contenedor = new Panel();
        public PantallaInicio(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            LoginUsuario Login = new LoginUsuario(contenedor);
            Desplegar(Login);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
