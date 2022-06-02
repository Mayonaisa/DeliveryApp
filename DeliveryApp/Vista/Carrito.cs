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
    public partial class Carrito : Form
    {
        public Panel contenedor = new Panel();
        public CarritoC Carro = new CarritoC();

        Solicita soli = new Solicita();


        public Carrito(Panel p,CarritoC c)
        {
            contenedor = p;
            Carro = c;
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            MenuCliente MenuClienteV = new MenuCliente(contenedor,Carro);

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

        public void Carrito_Load(object sender, EventArgs e)
        {
            int y = 0;

            pnlCarrito.AutoScroll = true;
            Carro.leer();
            Carro.refrescarCarrito();
            soli.leer(Carro.IdUsuario, Carro.idOrden);
            
            if (Carro.estatus == "nulo")
            {
                //tabControl1.TabPages.Add(pnlCarrito);
                //tabControl1.TabPages.Remove(pnlCarga);
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                BRconfirmar.Text = "Confirmar";
                BRconfirmar.Enabled = true;
            }
            else
            {
                //tabControl1.TabPages.Add(pnlCarga);
                //tabControl1.TabPages.Remove(pnlCarrito);
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                switch (Carro.estatus)
                {
                    case "pendiente":
                        pnlBarraRoja.Width = pnlBarraGris.Width / 3;
                        pbEtapa.Image = Resources.etapa2;
                        lblProgreso.Text = "Pedido pendiente";
                        BRconfirmar.Enabled = true;
                        BRconfirmar.Text = "Cancelar";
                        break;
                    case "Aceptado":
                        BRconfirmar.Enabled = false;
                        pnlBarraRoja.Width = (pnlBarraGris.Width / 3)*2;
                        pbEtapa.Image = Resources.etapa1;
                        lblProgreso.Text = "Pedido aceptado";
                        break;
                    case "en camino":
                        BRconfirmar.Enabled = false;
                        pnlBarraRoja.Width = pnlBarraGris.Width;
                        pbEtapa.Image = Resources.etapa3;
                        lblProgreso.Text = "Pedido en camino";
                        break;
                    case "entregado":
                        BRconfirmar.Enabled = true;
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        Carro = new CarritoC();
                        Carro.crear();
                        BRconfirmar.Text = "Confirmar";
                        break;
                }
                
            }
            if (Carro.nombreProd.Count == 0)
                BRconfirmar.Enabled = false;

            if (Carro.idDetalle != "nulo")
            {
                lblMonto.Text = Carro.detalle.Monto.ToString();
            }

            for (int n = 0; n < Carro.nombreProd.Count; n++)
            {
                PanelProducto prueba = new PanelProducto(Carro);
                prueba.Crear_Panel_carrito(Carro.nombreProd[n], Carro.monto[n], Carro.cantidad[n], 0, y, this);
                this.pnlCarrito.Controls.Add(prueba);
                y += 82;
            }

            //cargarCarrito();
        }

        //public void cargarCarrito()
        //{
        //    int y = 0;
        //    for (int n = 0; n < Carro.nombreProd.Count; n++)
        //    {
        //        PanelProducto prueba = new PanelProducto(Carro);
        //        prueba.Crear_Panel_carrito(Carro.nombreProd[n], Carro.monto[n], Carro.cantidad[n], 0, y, this);
        //        this.pnlCarrito.Controls.Add(prueba);
        //        y += 82;
        //    }
        //    if (Carro.nombreProd.Count == 0)
        //        BRconfirmar.Enabled = false;
        //}

        private void BRconfirmar_Click(object sender, EventArgs e)
        {

            if (BRconfirmar.Text == "Confirmar")
            {
                Carro.update(Carro.idDetalle, "pendiente");
                string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");
                soli = new Solicita(Carro.IdUsuario, date, Carro.idOrden);
                //tabControl1.TabPages.Add(pnlCarga);
                //tabControl1.TabPages.Remove(pnlCarrito);
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                pnlBarraRoja.Width = pnlBarraGris.Width / 3;
                pbEtapa.Image = Resources.etapa2;
                lblProgreso.Text = "Pedido pendiente";
                BRconfirmar.Enabled = true;
                BRconfirmar.Text = "Cancelar";
            }
            else
            {
                Carro.update(Carro.idDetalle, "nulo");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                
                soli.borrar(Carro.IdUsuario, Carro.idOrden);
                BRconfirmar.Enabled = true;
                BRconfirmar.Text = "Confirmar";

            }
        }
    }
}
