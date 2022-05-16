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
    public partial class PedidosPendientes : Form
    {
        Recepcionista Rep=new Recepcionista();
        Panel contenedor=new Panel();
        Pedido pedidos;
        ConsultarPedido Consulta;
        string Mensaje;
        public PedidosPendientes(Recepcionista r, Panel p)
        {
            Rep = r;
            contenedor = p;
            
            //Dgv;
            InitializeComponent();
            dgvPedidos.CellClick += dgvPedidos_CellClick;
        }
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //metodo que se creara dinamicamente para
            //if (e.ColumnIndex == dgvPedidos.Columns["boton"].Index)
            //{
                
            //}
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

            DataGridViewButtonColumn Aceptar = new DataGridViewButtonColumn();
            Aceptar.UseColumnTextForButtonValue=true;
            Aceptar.Text = "Aceptar";
            Aceptar.Name ="estatusPed";
            dgvPedidos.Columns.Add(Aceptar);

            int cantidad=0;
            ConsultarPedido.cantidadPedidos(ref cantidad);
            int i = 0;

            while (i<cantidad)
            {
                dgvPedidos.Rows.Add(pedidos.Orden[i].IdOrden, pedidos.Detalle[i].IdDetalle, pedidos.Detalle[i].Monto, pedidos.Orden[i].Estatus,"NA","NA",pedidos.Persona1[i],pedidos.Solicitud[i].Fecha);
                i++;
            }
            



        }
    }
}
