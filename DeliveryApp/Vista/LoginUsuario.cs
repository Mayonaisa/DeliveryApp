using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp;
using DeliveryApp.Controladores;
using DeliveryApp.Vista;
using DeliveryApp.Modelos; //Son los modelos



namespace DeliveryApp
{
    public partial class LoginUsuario : Form
    {
        System.Windows.Forms.Panel contenedor = new System.Windows.Forms.Panel();
        Usuario usuario = new Usuario();
        public LoginUsuario(System.Windows.Forms.Panel p)
        {
            contenedor = p;
            
            InitializeComponent();
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
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


        private void label9_Click(object sender, EventArgs e)
        {
            CambiarContraseña Cambio = new CambiarContraseña(usuario, contenedor);
            Desplegar(Cambio);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PantallaInicio menu = new PantallaInicio(contenedor);
            Desplegar(menu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string correo = tbxCorreo.Text;
            string contraseña = tbxCon.Text;
            string mensaje = "";
            Usuario usuario = new Usuario();
            Recepcionista recepcionista = new Recepcionista(); ;
            Cliente cliente = new Cliente();

            if (Login.validarUsuario(contraseña, correo, ref mensaje, ref usuario))
            {
                if (Login.BuscarCliente(ref mensaje, ref usuario, ref cliente))
                {
                    MenuCliente vistaPrincipal = new MenuCliente(cliente);

                    this.Hide();
                    //vistaPrincipal.ShowDialog();
                    //Contenedor Cont = new Contenedor();
                    //Cont.Desplegar(vistaPrincipal);
                    Desplegar(vistaPrincipal);
                    this.Close();



                }
                else if (Login.BuscarRecepcionista(ref mensaje, ref usuario, ref recepcionista))
                {
                    ContenedorEmpleado MenuRep = new ContenedorEmpleado(recepcionista, contenedor);

                    this.Hide();
                    //MenuRep.ShowDialog();
                    Desplegar(MenuRep);
                    this.Close();
                }

            }
            else
            {
                lblMensaje.Text = mensaje;
            }
        }
    }
}
