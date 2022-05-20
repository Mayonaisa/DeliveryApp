using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class MenuCliente : Form
    {
        bool mostrar = true;
        Panel contenedor = new Panel();
        public MenuCliente(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            //panelMenu.Hide();
            panelMenu.Location = new Point(-291, -1);
            panelPrincipal.Location = new Point(-1, -1);
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            if(mostrar == false)
            {
                //panelMenu.Hide();
                //panelPrincipal.Location = new Point(-1, -1);
                timer1.Start();
                mostrar = true;

            }
            else
            {
                //panelMenu.Show();
                //panelPrincipal.Location = new Point(288, -1);
                timer1.Start();
                mostrar = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point final = new Point(288, -1);
            Point inicio = new Point(-1, -1);
            if(mostrar == false)
            {
                //289
                if(panelPrincipal.Location.X >= final.X)
                {
                    timer1.Stop();
                }
                
                if(panelPrincipal.Location.X + 10 > final.X)
                {
                    int dif = final.X - (panelPrincipal.Location.X);
                    panelMenu.Location = new Point(panelMenu.Location.X + dif, -1);
                    panelPrincipal.Location = new Point(panelPrincipal.Location.X + dif, -1);
                }
                else
                {
                    panelMenu.Location = new Point(panelMenu.Location.X + 10, -1);
                    panelPrincipal.Location = new Point(panelPrincipal.Location.X + 10, -1);
                }
            }
            else
            {
                if (panelPrincipal.Location.X <= inicio.X)
                {

                    timer1.Stop();
                }
                

                if (panelPrincipal.Location.X - 10 < inicio.X)
                {
                    int dif = inicio.X + (panelPrincipal.Location.X);
                    panelMenu.Location = new Point(panelMenu.Location.X - dif, -1);
                    panelPrincipal.Location = new Point(panelPrincipal.Location.X - dif, -1);
                }
                else
                {
                    panelMenu.Location = new Point(panelMenu.Location.X - 10, -1);
                    panelPrincipal.Location = new Point(panelPrincipal.Location.X - 10, -1);
                }
            }
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

        private void label11_Click(object sender, EventArgs e)
        {
            Carrito CarritoV = new Carrito(contenedor);

            this.Hide();
            Desplegar(CarritoV);
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HistorialPedidos HistorialV = new HistorialPedidos(contenedor);

            this.Hide();
            Desplegar(HistorialV);
            this.Close();
        }

        private void botonRedondo16_Click(object sender, EventArgs e)
        {

        }
    }
}
