using DeliveryApp.Recursos;
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
    public partial class ConsultaEspecificaHistorial : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        string idOrden = "";

        public ConsultaEspecificaHistorial(Panel p, CarritoC c, string id)
        {
            contenedor = p;
            Carro = c;
            idOrden = id;
            InitializeComponent();
        }

        private void ConsultaEspecificaHistorial_Load(object sender, EventArgs e)
        {
            Carro.consultaHistorial(idOrden);
            txtNomCliente.Texts = Carro.nombreCliente; //el nombre del cliente
            txtDirCliente.Texts = Carro.direccion;
            txtNomRep.Texts = Carro.nombreRepartidor;
            txtNomRec.Texts = Carro.nombreRec;

            int y = 0;
            bool t = true;
            Carro.consultaEsp(idOrden,t); //esto ejecuta un método que devuelve los valores por producto, osea, la lista de productos, su precio y cantidad (idOrden ya lo tienes, está arriba) ejecuta t como true para sacar eso
            for(int n = 0; n < Carro.nombreProd.Count; n++)
            {
                PanelProducto prueba = new PanelProducto(Carro);
                prueba.Crear_Panel_consulta(Carro.nombreProd[n], Carro.monto[n], Carro.cantidad[n], 0, y);//esos son los datos de nombre del producto, monto y cantidad según su indice en un listas
                this.pnlHistorial.Controls.Add(prueba);
                y += 82;
            }
            t = false;
            Carro.consultaEsp(idOrden, t); //por otro lado, si ejecutas t como false te devuelve el monto total en el la lista monto indice 0 (monto[0])
            PanelProducto prueba2 = new PanelProducto(Carro);
            prueba2.Crear_Panel_consulta("Total pagado:", Carro.monto[0], "", pnlHistorial.Location.X, (pnlHistorial.Location.Y)+pnlHistorial.Height + 40);
            this.Controls.Add(prueba2);
            prueba2.BRcantidad.Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {
            HistorialPedidos HistorialV = new HistorialPedidos(contenedor, Carro);

            this.Hide();
            Desplegar(HistorialV);
            this.Close();
        }
    }
}
