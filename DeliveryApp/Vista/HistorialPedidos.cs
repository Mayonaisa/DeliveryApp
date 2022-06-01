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
    public partial class HistorialPedidos : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        
        public HistorialPedidos(Panel p, CarritoC c)
        {
            contenedor = p;
            Carro = c;
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

        private void botonRedondo7_Click(object sender, EventArgs e)
        {
            MenuCliente MenuClienteV = new MenuCliente(contenedor,Carro);

            this.Hide();
            Desplegar(MenuClienteV);
            this.Close();
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            int y = 0;
            if (Carro.estatus == "entregado")
            {
                Carro = new CarritoC();
                Carro.crear();
            }
            Carro.Historial();
            for (int n = 0; n < Carro.fechaH.Count; n++)
            {
                PanelProducto prueba = new PanelProducto(Carro);
                prueba.Crear_Panel_historial(Carro.fechaH[n], Carro.montoH[n], Carro.cantidadH[n], 0, y);
                this.pnlHistorial.Controls.Add(prueba);
                y += 82;
            }
        }
    }
}
