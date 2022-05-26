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
            DeliveryApp.Vista.CambiarContraseña Cambio = new DeliveryApp.Vista.CambiarContraseña(contenedor);
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

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            DeliveryApp.Vista.CambiarContraseña vistaPrincipal = new DeliveryApp.Vista.CambiarContraseña(contenedor);
            this.Hide();
            Desplegar(vistaPrincipal);
            this.Close();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // login
            int tipoUsuario = Login.ingresar(tbxCorreo.Texts, tbxContraseña.Texts);

            switch (tipoUsuario)
            {
                case 0:
                    MessageBox.Show("usuario no existe");
                    break;
                case 1:
                    MessageBox.Show("contraseña incorrecta");
                    break;
                case 2:
                    MessageBox.Show("administrador");
                    //MenuAdministrador menu = new MenuAdministrador();
                    //Desplegar(menu);
                    break;
                case 3:
                    MessageBox.Show("recepcionista");
                    //ContenedorEmpleado menu = new ContenedorEmpleado();
                    //Desplegar(menu);
                    break;
                case 4:
                    MessageBox.Show("usuario normal");
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;
            }
        }

        private void pnlInferior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 1, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 0, ButtonBorderStyle.Solid);// bottom
        }
    }
}
