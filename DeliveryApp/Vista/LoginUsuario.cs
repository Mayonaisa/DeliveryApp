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
        Panel contenedor = new Panel();
        Usuario usuario = new Usuario();
        public LoginUsuario(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo= textBox1.Text;
            string contraseña = textBox2.Text;
            string mensaje = "";
            
            Recepcionista recepcionista=new Recepcionista(); ;
            Cliente cliente = new Cliente(); 
            
            if (Login.validarUsuario(contraseña,correo, ref mensaje, ref usuario))
            {
                 if (Login.BuscarCliente(ref mensaje,ref usuario,ref cliente))
                {
                    Pantalla_Principal vistaPrincipal = new Pantalla_Principal(cliente);

                    this.Hide();
                    //vistaPrincipal.ShowDialog();
                    //Contenedor Cont = new Contenedor();
                    //Cont.Desplegar(vistaPrincipal);
                    Desplegar(vistaPrincipal);
                    this.Close();



                }
                 else if (Login.BuscarRecepcionista(ref mensaje, ref usuario, ref recepcionista))
                {
                    MenuRecepcionista MenuRep = new MenuRecepcionista(recepcionista,contenedor);

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
            //MenuRecepcionista Recep = new MenuRecepcionista();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string correo = textBox1.Text;
            string contraseña = textBox2.Text;
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
                    MenuRecepcionista MenuRep = new MenuRecepcionista(recepcionista,contenedor);

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
            //MenuRecepcionista Recep = new MenuRecepcionista();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            CambiarContraseña Cambio = new CambiarContraseña(usuario,contenedor);
            Desplegar(Cambio);
        }
    }
}
