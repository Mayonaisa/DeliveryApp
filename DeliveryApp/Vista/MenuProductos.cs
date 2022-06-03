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
        Administrador Rep = new Administrador();
        Panel contenedor = new Panel();

        public MenuProductos(Panel p, Administrador r, string id)
        {
            contenedor = p;
            Rep = r;
            pro = new Producto(id);
            InitializeComponent();
        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            txtId.Texts = pro.IdProducto;
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(f1())
            {
                MessageBox.Show(Producto.actualizarCliente(txtId.Texts, tbxPrecio.Texts, tbxDisponibilidad.Texts));
                ConsultaGeneralProductos ConPro = new ConsultaGeneralProductos(Rep, contenedor);
                Desplegar(ConPro);
            }
        }

        private bool f1()
        {
            try
            {
                if(tbxPrecio.Texts != "")
                {
                    
                    double a = Convert.ToDouble(tbxPrecio.Texts);
                    return true;
   
                }
                else
                {
                    MessageBox.Show("El precio esta vacio");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("El precio no es valido");
                return false;
            }
        }
    }
}
