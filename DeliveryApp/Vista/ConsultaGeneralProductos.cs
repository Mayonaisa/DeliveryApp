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
        Panel contenedor = new Panel();
        Administrador Rep = new Administrador();
        string Mensaje;

        public ConsultaGeneralProductos(Administrador r, Panel p)
        {
            Rep = r;
            contenedor = p;
            InitializeComponent();
        }

        public ConsultaGeneralProductos(Panel p)
        {
            Rep = null;
            contenedor = p;
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultaGeneralProductos_Load(object sender, EventArgs e)
        {
            cbDis.SelectedIndex = 0;
            cbPre.SelectedIndex = 0;
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
            //ContenedorEmpleado menuR = new ContenedorEmpleado(Rep, contenedor);
            //Desplegar(menuR);
            MenuRecep_Admin Men = new MenuRecep_Admin(Rep, contenedor);
            //ContenedorCatalogos.Controls.RemoveAt(0);
            Desplegar(Men);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //metodo que se creara dinamicamente para
            if (e.RowIndex == -1)
            {

            }
            else
            {
                string error = null;
                string VehID = null;

                VehID = dgvProductos[0, e.RowIndex].Value.ToString().Trim();
                MenuProductos ConsultarProductos = new MenuProductos(contenedor,Rep,VehID);

                if (error != null)
                {
                    MessageBox.Show(error);
                }

                Desplegar(ConsultarProductos);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            string Mensaje = null;
            int max = Pro.cantidad();

            int p = 0, d = 0;

            if (rbDis.Checked)
            {
                p = 0;
                d = cbDis.SelectedIndex + 1;
            }
            if (rbPre.Checked)
            {
                d = 0;
                p = cbPre.SelectedIndex + 1;
            }
            if(rbtodo.Checked)
            {
                p = 0; d = 0;
            }

            List<Producto> list = new List<Producto>();
            Producto.ListaProductosParametrizados(ref list, max, d, p);

            foreach(Producto prod in list)
            {
                dgvProductos.Rows.Add(prod.IdProducto, prod.Nombre, prod.Disponible, prod.Precio);
                //MessageBox.Show(prod.IdProducto + prod.Nombre + prod.Disponible.ToString() + prod.Precio.ToString());
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
