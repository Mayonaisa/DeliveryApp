using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Vista;

namespace DeliveryApp.Vista
{
    public partial class Contenedor : Form
    {
        

        public Contenedor()
        {
            InitializeComponent();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            LoginUsuario LoginUsuarioV = new LoginUsuario(PanelContenedor);
            PanelContenedor.Width = LoginUsuarioV.Width;
            PanelContenedor.Height = LoginUsuarioV.Height;
            this.AutoSize = true;
            LoginUsuarioV.FormBorderStyle = FormBorderStyle.None;
            LoginUsuarioV.TopLevel = false;
            PanelContenedor.Controls.Add(LoginUsuarioV);
            LoginUsuarioV.Dock = DockStyle.Fill;
            LoginUsuarioV.Show();
        }

        public void Desplegar (Form f)
        {
            if(PanelContenedor.Controls.Count > 0)
            {
                PanelContenedor.Controls.RemoveAt(0);
            }
            PanelContenedor.Width = f.Width;
            PanelContenedor.Height = f.Height;
            this.AutoSize = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            PanelContenedor.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
