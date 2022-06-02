using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
using DeliveryApp.Modelos;
using DeliveryApp.Controladores;

namespace DeliveryApp.Vista
{
    public partial class ConsultaEspecificaPedidosRecep : Form
    {
        Panel contenedor;
        Pedido Pedidos;
        Repartidor Rep;
        List<Repartidor> Repartidores = new List<Repartidor>();
        List<Vehiculo> Vehiculos = new List<Vehiculo>();
        Vehiculo Veh;
        Recepcionista recepcionista;
        public ConsultaEspecificaPedidosRecep(Panel p, Pedido Consulta, Repartidor R, Vehiculo V, Recepcionista Recepcio)
        {
            Rep = R;
            Veh = V;
            Pedidos = Consulta;
            contenedor= p;
            recepcionista = Recepcio;
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string Mensaje = null;
            string mensC = null;
            Entrega Ent = new Entrega();
            Pedido P=new Pedido();
            Registra Reg=new Registra();
            DateTime Actual = DateTime.Now;
            if (ConsultarPedido.ValidarEntrega(Pedidos.IOrden.IdOrden,Ent,ref Mensaje)==true)
            {
                MessageBox.Show(Mensaje);

            }
            else
            {
                foreach (Repartidor R in Repartidores)
                {
                    if (R.Nombre + R.APaterno + R.AMaterno == cmbxRepart.Texts)
                    {
                        Rep.IdPersona = R.IdPersona;
                    }
                }
                foreach (Vehiculo V in Vehiculos)
                {
                    string Cad = V.Marca + " " + V.Modelo + " " + V.Año;
                    if ( Cad== cmbxVehi.Texts)
                    {
                        Veh.IdVehiculo = V.IdVehiculo;
                    }

                }
                
                ConsultarPedido.NuevaEntrega(Pedidos.IOrden.IdOrden, Veh.IdVehiculo, Actual.ToString(), Rep.IdPersona, ref P, ref mensC, ref Ent);


                if (mensC == null)
                {
                    ConsultarPedido.ConfirmarPedido(Pedidos.IOrden.IdOrden, ref P);
                    txtEstatus.Texts = "en camino";
                    ConsultarPedido.NuevoRegistra(Pedidos.IOrden.IdOrden, Actual.ToString(),recepcionista.IdPersona,ref Reg);
                    MessageBox.Show("Se Registro la entrega del pedido");
                }
                else
                {
                    MessageBox.Show("Acepte el pedido y rellene los campos faltantes");
                }

                

                if (txtEstatus.Texts=="en camino")
                {
                    btnEntregado.Enabled = true;
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
        private void rjButton2_Click(object sender, EventArgs e)
        {
            Recepcionista R=new Recepcionista();
            PedidosPendientes Volver = new PedidosPendientes(R,contenedor);
            Desplegar(Volver);
            

        }

        private void ConsultaEspecificaPedidosRecep_Load(object sender, EventArgs e)
        {
            string mensaje =null;
            txtCliente.Texts = Pedidos.Ipersona1.Nombre+" "+ Pedidos.Ipersona1.APaterno+" "+ Pedidos.Ipersona1.AMaterno;
            txtEstatus.Texts =Pedidos.IOrden.Estatus;
            txtTotal.Texts =Pedidos.IDetalle.Monto.ToString();
            txtHoraSol.Texts = Pedidos.ISolicita.Fecha;

            txtCalle1.Texts = Pedidos.IDire1.Calle1;
            txtCalle2.Texts=Pedidos.IDire1.Calle2;
            txtCiudad.Texts = Pedidos.IDire1.Ciudad;
            txtColonia.Texts= Pedidos.IDire1.Colonia;
            txtNumCasa.Texts= Pedidos.IDire1.NumCasa;
            ConsultarPedido.ObtenerRepartidores(ref Repartidores,ref mensaje, Rep);
            ConsultarPedido.ObtenerVehiculos(ref Vehiculos, ref mensaje,Veh);

            foreach(Repartidor R in Repartidores)
            {
                cmbxRepart.Items.Add(R.Nombre+R.APaterno+R.AMaterno);
            }
            foreach (Vehiculo V in Vehiculos)
            {
                cmbxVehi.Items.Add(V.Marca+" " + V.Modelo+" "+V.Año);
            }

            cmbxRepart.Texts =Rep.Nombre+Rep.APaterno+Rep.APaterno;
            if (Veh.IdVehiculo != "")
            {
                cmbxVehi.Texts = Veh.Marca +" "+ Veh.Modelo + ", " + Veh.Año;
            }
            if (txtEstatus.Texts != "Entregado")
            {
                btnEntregado.Enabled = true;
            }
            if (txtEstatus.Texts == "Entregado")
            {
                btnEntregado.Enabled = false;
                rjButton1.Enabled = false;
            }
            if (mensaje != null)
            {
                MessageBox.Show(mensaje);
            }

            
        }

        private void cmbxVehi_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            Pedidos.PedidoIndi(Pedidos.IOrden.IdOrden);
            if (Pedidos.IOrden.Estatus == "Entregado")
            {
                
            }
            else
            {
                ConsultarPedido.ConfirmarEntregapedido(Pedidos.IOrden.IdOrden, Pedidos);
                txtEstatus.Texts = "Entregado";
                MessageBox.Show("Pedido Concluido");
                btnEntregado.Enabled = false;
                rjButton1.Enabled = false;
            }
           
            
            
            
        }
    }
}
