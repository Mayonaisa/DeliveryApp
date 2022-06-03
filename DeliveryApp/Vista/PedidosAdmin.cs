using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Controladores;
using DeliveryApp.Vista;
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class PedidosAdmin : Form
    {
        Recepcionista Rep=new Recepcionista();
        Panel contenedor=new Panel();
        Pedido pedidos;
        DataGridViewButtonColumn Aceptar = new DataGridViewButtonColumn();
        Repartidor Repar;
        Vehiculo Veh;
        string Mensaje;

        
        public PedidosAdmin(Recepcionista r, Panel p)
        {
            Rep = r;
            contenedor = p;

            //Dgv;
            InitializeComponent();
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            
        }
        // boton de aceptar pedidos
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string error = null;
            pedidos = new Pedido();
            Repar = new Repartidor();
            Veh = new Vehiculo();
            string PedID = null;
            PedID = dgvPedidos[0, e.RowIndex].Value.ToString().Trim();
            ConsultarPedido.PedidoEspecifico(PedID, ref pedidos, ref Repar, ref Veh, ref error);
            ConsultaEspecificaPedidosAdmin Pedidos = new ConsultaEspecificaPedidosAdmin(contenedor, pedidos, Repar, Veh, Rep);
            if (error != null)
            {
                MessageBox.Show(error);
            }
            Desplegar(Pedidos);


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

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            ConsultarPedido.ObtenerPedido(ref pedidos,ref Mensaje);

            

            int cantidad=0;
            ConsultarPedido.cantidadPedidos(ref cantidad);
            int i = 0;
            Repartidor IREP=new Repartidor();
            Vehiculo IVEH=new Vehiculo();
            while (i<cantidad)
            {
                ConsultarPedido.RepartidorEspecifico(pedidos.Orden[i].IdOrden, ref IREP,ref  Mensaje);
                ConsultarPedido.VehiculoEspecifico(pedidos.Orden[i].IdOrden, ref IVEH, ref Mensaje);
                dgvPedidos.Rows.Add(pedidos.Orden[i].IdOrden, pedidos.Detalle[i].IdDetalle, pedidos.Detalle[i].Monto, pedidos.Orden[i].Estatus,IREP.Nombre+" "+IREP.APaterno+" "+IREP.AMaterno,IVEH.Marca+" "+IVEH.Modelo+" "+IVEH.Año, pedidos.Persona1[i].Nombre+" "+ pedidos.Persona1[i].APaterno+" "+ pedidos.Persona1[i].AMaterno, pedidos.Solicitud[i].Fecha, pedidos.Direc1[i].Colonia, pedidos.Direc1[i].NumCasa);
               
                i++;
            }
            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }



        }

        private void PedidosPendientes_Load(object sender, EventArgs e)
        {

            dgvPedidos.Rows.Clear();
            ConsultarPedido.ObtenerPedido(ref pedidos, ref Mensaje);
            int cantidad = 0;
            ConsultarPedido.cantidadPedidos(ref cantidad);
            int i = 0;
            Repartidor IREP = new Repartidor();
            Vehiculo IVEH = new Vehiculo();
            while (i < cantidad)
            {
                ConsultarPedido.RepartidorEspecifico(pedidos.Orden[i].IdOrden, ref IREP, ref Mensaje);
                ConsultarPedido.VehiculoEspecifico(pedidos.Orden[i].IdOrden, ref IVEH, ref Mensaje);
                dgvPedidos.Rows.Add(pedidos.Orden[i].IdOrden, pedidos.Detalle[i].IdDetalle, pedidos.Detalle[i].Monto, pedidos.Orden[i].Estatus, IREP.Nombre + " " + IREP.APaterno + " " + IREP.AMaterno, IVEH.Marca + " " + IVEH.Modelo + " " + IVEH.Año, pedidos.Persona1[i].Nombre + " " + pedidos.Persona1[i].APaterno + " " + pedidos.Persona1[i].AMaterno, pedidos.Solicitud[i].Fecha, pedidos.Direc1[i].Colonia, pedidos.Direc1[i].NumCasa);
                i++;
            }
            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
