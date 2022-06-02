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
using DeliveryApp.Recursos;



namespace DeliveryApp
{
    public partial class LoginUsuario : Form
    {
        System.Windows.Forms.Panel contenedor = new System.Windows.Forms.Panel();
        CarritoC Carro = new CarritoC();
        Color borde = Color.FromArgb(241, 241, 241);

        Usuario usuario;
        
        public LoginUsuario(System.Windows.Forms.Panel p, CarritoC c)
        {
            contenedor = p;
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


        private void label9_Click(object sender, EventArgs e)
        {
            DeliveryApp.Vista.CambiarContraseña Cambio = new DeliveryApp.Vista.CambiarContraseña(contenedor, Carro);
            Desplegar(Cambio);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PantallaInicio menu = new PantallaInicio(contenedor, null);
            Desplegar(menu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            DeliveryApp.Vista.CambiarContraseña vistaPrincipal = new DeliveryApp.Vista.CambiarContraseña(contenedor, Carro);
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
            // validar campos
            int val = Login.validarNomu(tbxCorreo.Texts);
            if (val == 0)
            {
                tbxCorreo.BorderColor = borde;
                if (tbxContraseña.Texts.Length < 30)
                {
                    // login
                    tbxContraseña.BorderColor = borde;

                    int tipoUsuario = Login.ingresar(tbxCorreo.Texts, tbxContraseña.Texts);

                    //usuario = new Usuario(tbxContraseña.Texts, tbxCorreo.Texts);

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
                            Usuario Recep = new Usuario(tbxContraseña.Texts, tbxCorreo.Texts);
                            ContenedorEmpleado menuR = new ContenedorEmpleado(Recep, contenedor);
                            Desplegar(menuR);
                            break;
                        case 4:
                            MessageBox.Show("usuario normal");
                            MenuCliente menu = new MenuCliente(contenedor, Carro);
                            Carro.IdUsuario = usuario.IdPersona.Trim();
                            Carro.Usuario = usuario.Nombre.Trim();
                            Desplegar(menu);
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña tiene más de 30 caracteres");
                    tbxContraseña.BorderColor = Color.Red;
                }
            }
            else if (val == 1)
            {
                MessageBox.Show("El usuario tiene más de 20 caracteres");
                tbxCorreo.BorderColor = Color.Red;
            }
            else if (val == 2)
            {
                MessageBox.Show("El usuario tiene caracteres invalidos");
                tbxCorreo.BorderColor = Color.Red;
            }
            else
            {
                MessageBox.Show("El usuario esta vacio");
                tbxCorreo.BorderColor = Color.Red;
            }
        }

        private void pnlInferior_Paint(object sender, PaintEventArgs e)
        {
            Color c = borde;
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 1, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 0, ButtonBorderStyle.Solid);// bottom
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int val = Login.validarNomu("Paola1234");
            if (val == 0)
            {
                tbxCorreo.BorderColor = borde;
                if (tbxContraseña.Texts.Length < 30)
                {
                    // login
                    tbxContraseña.BorderColor = borde;

                    int tipoUsuario = Login.ingresar("Paola1234", "Paola1234_30");

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
                            Usuario Recep = new Usuario("Paola1234_30", "Paola1234");
                            ContenedorEmpleado menuR = new ContenedorEmpleado(Recep, contenedor);
                            Desplegar(menuR);
                            break;
                        case 4:
                            MessageBox.Show("usuario normal");
                            MenuCliente menu = new MenuCliente(contenedor, Carro);
                            Desplegar(menu);
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            int val = Login.validarNomu("Roberto1234");
            if (val == 0)
            {
                tbxCorreo.BorderColor = borde;
                if (tbxContraseña.Texts.Length < 30)
                {
                    // login
                    tbxContraseña.BorderColor = borde;

                    int tipoUsuario = Login.ingresar("Roberto1234", "Roberto1234_1");
                    usuario = new Usuario("Roberto1234_1", "Roberto1234");

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
                            ContenedorEmpleado menuR = new ContenedorEmpleado(new Usuario(), contenedor);
                            Desplegar(menuR);
                            break;
                        case 4:
                            MessageBox.Show("usuario normal");
                            Carro.Verificar(usuario.IdPersona.Trim());
                            MenuCliente menu = new MenuCliente(contenedor, Carro);
                            Carro.IdUsuario = usuario.IdPersona.Trim();
                            Carro.Usuario = usuario.Nombre.Trim();
                            Desplegar(menu);
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }
                }
            }
        }
    }
}
