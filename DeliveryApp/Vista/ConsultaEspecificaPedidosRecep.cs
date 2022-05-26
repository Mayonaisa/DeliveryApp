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
        Vehiculo Veh;
        public ConsultaEspecificaPedidosRecep(Panel p, Pedido Consulta, Repartidor R, Vehiculo V)
        {
            Rep = R;
            Veh = V;
            Pedidos = Consulta;
            contenedor= p;
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
            ConsultarPedido.ObtenerPedido(ref Pedidos, ref Mensaje);

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
            txtCliente.Texts = Pedidos.Ipersona1;
            txtEstatus.Texts =Pedidos.IOrden.Estatus;
            txtTotal.Texts =Pedidos.IDetalle.Monto.ToString();
            
            ConsultarPedido.ObtenerRepartidores(ref Repartidores,ref mensaje, Rep);

            foreach(Repartidor R in Repartidores)
            {
                cmbxRepart.Items.Add(R.Nombre+R.APaterno+R.AMaterno);
            }
            cmbxRepart.Texts =Rep.Nombre+Rep.APaterno+Rep.APaterno;
            cmbxVehi.Texts =Veh.Marca+Veh.Modelo+", "+Veh.IdVehiculo;
            if (mensaje != null)
            {
                MessageBox.Show(mensaje);
            }

            
        }
    }
}
