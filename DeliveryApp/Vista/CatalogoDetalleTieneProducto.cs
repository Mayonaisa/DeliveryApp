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
        DetalleTieneProducto DetPed;
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
            ConsultarDetalleTieneProducto.ObtenerDetalleproducto(ref DetPed,ref Mensaje);

            int cantidad = 0;
            ConsultarDetalleTieneProducto.cantidadPedidos(ref cantidad);
            int i = 0;

            while (i < cantidad)
            {
                dgvPedidos.Rows.Add(DetPed.IdDetalle[i],DetPed.Cantidad1[i],DetPed.Idproducto[i]);
                i++;
            }

        }
    }
}
