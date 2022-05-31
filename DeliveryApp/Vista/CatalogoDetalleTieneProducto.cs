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
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class CatalogoDetalleTieneProducto : Form
    {
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();
        Pedido pedidos;
        DetalleTieneProducto DetPed=new DetalleTieneProducto();
        List<DetalleTieneProducto> DetPedList=new List<DetalleTieneProducto>();
        public CatalogoDetalleTieneProducto(Recepcionista r, Panel p)
        {
            Rep = r;
            contenedor = p;
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
        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string Mensaje=null;
            dgvPedidos.Rows.Clear();

            int cantidad = DetPed.CantidadDetalles();
            ConsultarDetalleTieneProducto.ObtenerDetallesProductos(ref DetPedList,ref Mensaje,DetPed);
            int i = 0;

            while (i < cantidad)
            {
                dgvPedidos.Rows.Add(DetPedList[i].IdDetalle, DetPedList[i].Cantidad, DetPedList[i].IdProducto);
                i++;
            }

        }
    }
}
