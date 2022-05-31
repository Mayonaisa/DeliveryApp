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
    public partial class ConsultaGeneralProductos : Form
    {
        List <Producto> LProductos=new List<Producto>();
        Producto Pro=new Producto();
        public ConsultaGeneralProductos()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            string Mensaje = null;
            int max = Pro.cantidad();
            ConsultarProductos.ObtenerProducto(ref LProductos, ref Mensaje, Pro);
            int i = 0;
            while (i < max)
            {
                dgvProductos.Rows.Add(LProductos[i].IdProducto, LProductos[i].Nombre, LProductos[i].Disponible, LProductos[i].Precio);
                i++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
