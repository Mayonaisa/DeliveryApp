using DeliveryApp.Controladores;
using DeliveryApp.Modelos;
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
    public partial class ConsultaEspecificaDetalle : Form
    {
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();
        Pedido pedidos;
        DetalleTieneProducto DetPed = new DetalleTieneProducto();
        List<DetalleTieneProducto> DetPedList = new List<DetalleTieneProducto>();

        public ConsultaEspecificaDetalle(Panel p)
        {
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuRecep_Admin Men = new MenuRecep_Admin(null, contenedor);
            Desplegar(Men);
            MessageBox.Show("a");
        }

        private void ConsultaEspecificaDetalle_Load(object sender, EventArgs e)
        {
            string Mensaje = null;
            dgvPedidos.Rows.Clear();

            int cantidad = DetPed.CantidadDetalles();
            ConsultarDetalleTieneProducto.ObtenerDetallesProductos(ref DetPedList, ref Mensaje, DetPed);
            int i = 0;

            while (i < cantidad)
            {
                dgvPedidos.Rows.Add(DetPedList[i].IdDetalle, DetPedList[i].Cantidad, DetPedList[i].IdProducto);
                i++;
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //metodo que se creara dinamicamente para
            if (e.RowIndex == -1)
            {

            }
            else
            {
                string VehID = dgvPedidos[0, e.RowIndex].Value.ToString().Trim();
                CatalogoDetalleTieneProducto pnt = new CatalogoDetalleTieneProducto(contenedor, VehID);
                Desplegar(pnt);
                MessageBox.Show("a");
            }
        }
    }
}