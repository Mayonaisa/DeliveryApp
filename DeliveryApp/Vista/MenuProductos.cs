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
    public partial class MenuProductos : Form
    {
        Producto pro;
        List<Vehiculo> lve;
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();

        public MenuProductos(Panel p, Recepcionista r, string id)
        {
            contenedor = p;
            Rep = r;
            pro = new Producto(id);
            InitializeComponent();
        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            cbxId.Texts = pro.IdProducto;
            tbxDisponibilidad.Texts = pro.Disponible;
            tbxPrecio.Texts = pro.Precio.ToString();
            txtNombre.Texts = pro.Nombre;
            
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConsultaGeneralProductos ConPro = new ConsultaGeneralProductos(Rep, contenedor);
            Desplegar(ConPro);
        }
    }
}
