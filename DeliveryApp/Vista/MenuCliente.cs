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
using DeliveryApp.Recursos;

namespace DeliveryApp.Vista
{
    public partial class MenuCliente : Form
    {
        bool mostrar = true;
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        public MenuCliente(Panel p, CarritoC c)
        {
            contenedor = p;
            Carro = c;
            InitializeComponent();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            //panelMenu.Hide();
            if(Carro.estatus == "entregado")
            {
                Carro = new CarritoC();
                Carro.crear();
            }

            panelMenu.Location = new Point(-291, -1);
            panelPrincipal.Location = new Point(-1, -1);
            panelPrincipal.Size = contenedor.Size;
            panel1.Width = panelPrincipal.Width;
            panelMenu.Height = contenedor.Height;
            lblNombreUsu.Text = Carro.Usuario;
            lblNombreUsu.Location = new Point((panelMenu.Width - lblNombreUsu.Width) / 2, lblNombreUsu.Location.Y);
            //Carro.crear();

            //CarritoC nuevo = new CarritoC();
            //nuevo.nuevo_producto();


            ////////////////////////////////////////////Prueba/////////////////////////
            //PanelProducto prueba = new PanelProducto(13,Carro);
            //prueba.Crear_Panel_menu(prueba.prod.Nombre, 325, 522);
            //this.panelPrincipal.Controls.Add(prueba);

            //PanelProducto prueba2 = new PanelProducto(14, Carro);
            //prueba2.Crear_Panel_menu(prueba2.prod.Nombre, 325, 680);
            //this.panelPrincipal.Controls.Add(prueba2);
            int y = 0;
            for(int i = 0; i < 40; i++)
            {
                PanelProducto prueba = new PanelProducto(i.ToString(), Carro);
                prueba.Crear_Panel_menu(prueba.prod.Nombre, 25, y);
                pnlMenu.Controls.Add(prueba);
                y+=156;
                prueba.MenuV = this;
                prueba.contenedor = contenedor;
            }
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            
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
            Carrito CarritoV = new Carrito(contenedor,Carro);

            this.Hide();
            Desplegar(CarritoV);
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HistorialPedidos HistorialV = new HistorialPedidos(contenedor,Carro);

            this.Hide();
            Desplegar(HistorialV);
            this.Close();
        }

        private void botonRedondo16_Click(object sender, EventArgs e)
        {

        }

        void agregar (string nombre, string monto, int cantidad)
        {

        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            agregar("pizza", "120", 3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mostrar == false)
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

        private void label13_Click(object sender, EventArgs e)
        {
            LoginUsuario loginV = new LoginUsuario(contenedor, Carro);

            this.Hide();
            Desplegar(loginV);
            this.Close();
        }
    }
}
