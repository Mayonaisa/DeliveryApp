using DeliveryApp.Controladores;
using DeliveryApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Vista
{
    public partial class RegistrarProducto : Form
    {
        Producto pro;
        List<Vehiculo> lve;
        Administrador Rep = new Administrador();
        Panel contenedor = new Panel();

        public RegistrarProducto(Panel p, Administrador r, string id)
        {
            contenedor = p;
            Rep = r;
            pro = new Producto(id);
            InitializeComponent();
        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            
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
            MenuRecep_Admin ConPro = new MenuRecep_Admin(Rep, contenedor);
            Desplegar(ConPro);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                MessageBox.Show(Producto.registrar(txtNombre.Texts, cbxDis.Texts, tbxPrecio.Texts));
                System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream file =
                    thisExe.GetManifestResourceStream("ZedGraph.Demo.ngc4414.jpg");

                // If the resource is not present it will be null or empty
                if (null != file)
                {
                    Image image = Image.FromStream(file);
                }
            }
        }

        private bool validar()
        {
            if(txtNombre.Texts != "")
            {
                if (txtNombre.Texts.Length < 20)
                {
                    if(Regex.IsMatch(txtNombre.Texts, @"^[\p{L} \.'\-]+$"))
                    {
                        try
                        {
                            if (tbxPrecio.Texts != "")
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
                    else
                    {
                        MessageBox.Show("El nombre es invalido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre tiene mas de 20 caracteres");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El nombre esta vacio");
                return false;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string a = "";
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = a;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                a = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pictureBox1.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}