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
    public partial class Carrito : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();

        public CarritoC Carro1 { get => Carro; set => Carro = value; }

        public Carrito(Panel p,CarritoC c)
        {
            contenedor = p;
            Carro1 = c;
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            MenuCliente MenuClienteV = new MenuCliente(contenedor,Carro1);

            this.Hide();
            Desplegar(MenuClienteV);
            this.Close();
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

        private void Carrito_Load(object sender, EventArgs e)
        {
            int y = 600;
            ////prueba
            for(int n = 0; n < Carro1.nombreProd.Count;n++)
            {
                PanelProducto prueba = new PanelProducto(Carro1);
                prueba.Crear_Panel_carrito(Carro1.nombreProd[n], Carro1.monto[n], Carro1.cantidad[n], 320, y);
                this.Controls.Add(prueba);
                y += 82;
            }
            
        }
    }
}
