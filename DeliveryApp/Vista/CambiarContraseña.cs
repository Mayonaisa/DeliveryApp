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
using DeliveryApp.Vista;
using DeliveryApp.Recursos;

namespace DeliveryApp.Vista
{
    public partial class CambiarContraseña : Form
    {
        CarritoC Carro = new CarritoC();
        Panel contenedor = new Panel();
        
        public CambiarContraseña(Panel p, CarritoC c)
        { 
            contenedor= p;
            Carro = c;
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

        private void Regresar_Click(object sender, EventArgs e)
        {
            LoginUsuario Login = new LoginUsuario(contenedor, Carro);
            Desplegar(Login);
            
        }
        

        private void Enviar_Click(object sender, EventArgs e)
        {
            int val = DeliveryApp.Controladores.CambiarContraseña.validarCorreo(tbxCorreo.Texts);

            // Numero de casa
            if (val == 3)
            {
                tbxCorreo.BorderColor = Color.Red;
                MessageBox.Show("El correo esta vacio");
            }
            else
            {
                if (val == 0)
                {
                    tbxCorreo.BorderColor = Color.FromArgb(241, 241, 241);
                    if (DeliveryApp.Controladores.CambiarContraseña.recuperarContraseña(tbxCorreo.Texts))
                    {
                        MessageBox.Show("Se ha enviado la contraseña a su correo");
                    }
                    else
                    {
                        MessageBox.Show("No existe una cuenta con ese correo");
                    }
                }
                else if (val == 1)
                {
                    tbxCorreo.BorderColor = Color.Red;
                    MessageBox.Show("El correo tiene más de 40 caracteres");
                }
                else
                {
                    tbxCorreo.BorderColor = Color.Red;
                    MessageBox.Show("Ingrese un correo valido");
                }
            }
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 0, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 1, ButtonBorderStyle.Solid);// bottom
        }

        //private void CambiarContraseña_Load(object sender, EventArgs e)
        //{
        //    DeliveryApp.Controladores.CambiarContraseña control = new DeliveryApp.Controladores.CambiarContraseña();
        //    MessageBox.Show(control.msg);
        //}
    }
}