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
using DeliveryApp.Modelos;
using DeliveryApp.Properties;

namespace DeliveryApp.Vista
{
    public partial class ProductoV : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        private Producto prod;
        public ProductoV(Panel p, CarritoC c)
        {
            contenedor = p;
            Carro = c;
            InitializeComponent();
        }

        internal Producto Prod { get => prod; set => prod = value; }

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

        private void label4_Click(object sender, EventArgs e)
        {
            MenuCliente MenuClienteV = new MenuCliente(contenedor, Carro);

            this.Hide();
            Desplegar(MenuClienteV);
            this.Close();
        }

        private void ProductoV_Load(object sender, EventArgs e)
        {
            if (Carro.estatus == "entregado")
            {
                Carro = new CarritoC();
                Carro.crear();
            }

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryApp.Properties.Resources));

            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject(prod.Nombre.Replace(' ', '_'))));
            txtProducto.Texts = prod.Nombre.Replace('_', ' ');
            txtPrecio.Texts = "$" + prod.Precio.ToString() + " MXN";
            txtDisponibilidad.Texts = prod.Disponible;
        }
    }
}
