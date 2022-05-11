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
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class CambiarContraseña : Form
    {
        Panel contenedor = new Panel();
        Usuario usuario = new Usuario();
        public CambiarContraseña(Usuario Persona, Panel p)
        {
            usuario= Persona;   
            contenedor= p;  

            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginUsuario Login = new LoginUsuario(contenedor);
            Desplegar(Login);
            
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
    }
}
