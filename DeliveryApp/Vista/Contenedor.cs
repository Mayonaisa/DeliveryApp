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
            PantallaInicio Inicio = new PantallaInicio(PanelContenedor);
            PanelContenedor.Width = Inicio.Width;
            PanelContenedor.Height = Inicio.Height;
            this.AutoSize = true;
            Inicio.FormBorderStyle = FormBorderStyle.None;
            Inicio.TopLevel = false;
            PanelContenedor.Controls.Add(Inicio);
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();
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
