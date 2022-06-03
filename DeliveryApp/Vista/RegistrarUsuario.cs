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
    public partial class RegistrarUsuario : Form
    {
        private int fase = 0;
        CarritoC Carro = new CarritoC();
        System.Windows.Forms.Panel contenedor = new System.Windows.Forms.Panel();
        Usuario usuario = new Usuario();
        Color borde = Color.FromArgb(241, 241, 241);

        public RegistrarUsuario(System.Windows.Forms.Panel p, CarritoC c)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            switch (fase)
            {
                case 0:
                    PantallaInicio menu = new PantallaInicio(contenedor,Carro);
                    Desplegar(menu);
                    break;
                case 1:
                    Point p2 = registro2.Location;
                    registro2.Location = registro1.Location;
                    registro1.Location = p2;
                    fase--;
                    break;
                case 2:
                    Point p3 = registro3.Location;
                    registro3.Location = registro2.Location;
                    registro2.Location = p3;
                    btinSiguiente.Text = "Siguiente";
                    fase--;
                    break;
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

        private void pnlInferior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 1, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 0, ButtonBorderStyle.Solid);// bottom
        }

        private void btinSiguiente_Click(object sender, EventArgs e)
        {
            switch(fase)
            {
                case 0:
                    if(validarFase1())
                    {
                        Point p1 = registro1.Location;
                        registro1.Location = registro2.Location;
                        registro2.Location = p1;
                        fase++;
                    }
                    break;
                case 1:
                    if(validarFase2())
                    {
                        Point p2 = registro2.Location;
                        registro2.Location = registro3.Location;
                        registro3.Location = p2;
                        btinSiguiente.Text = "Registrar";
                        fase++;
                    }
                    break;
                case 2:
                    if(validarFase3())
                    {
                        int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                        int dob = int.Parse(dtpFechaNacim.Value.ToString("yyyyMMdd"));
                        int age = (now - dob) / 10000;

                        string msg = DeliveryApp.Controladores.RegistrarUsuario.registrar(tbxUsuario.Texts, tbxContraseña.Texts, tbxCorreo.Texts, cbxPais.Texts, cbxEstado.Texts, cbxCiudad.Texts, cbxCalle1.Texts, cbxCalle2.Texts, cbxColonia.Texts, cbxNumCasa.Texts, tbxNombre.Texts, " ", tbxApaterno.Texts, tbxAmaterno.Texts, tbxTelefono.Texts, dtpFechaNacim.Value.ToString(), age, cbxSexo.Texts, tbxRFC.Texts);
                        MessageBox.Show(msg);

                        if (msg == "Se ha registrado correctamente")
                        {
                            PantallaInicio menu = new PantallaInicio(contenedor, Carro);
                            Desplegar(menu);
                        }
                    }
                    break;
            }
        }

        private bool validarFase1()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarNombre(tbxNombre.Texts);

            if (val == 3)
            {
                tbxNombre.BorderColor = Color.Red;
                MessageBox.Show("El nombre esta vacio");
                return false;
            }
            else
            {
                if (val == 0)
                {
                    tbxNombre.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarApellido(tbxApaterno.Texts);

                    if (val == 3)
                    {
                        tbxApaterno.BorderColor = Color.Red;
                        MessageBox.Show("El apellido paterno esta vacio");
                        return false;
                    }
                    else
                    {
                        if (val == 0)
                        {
                            tbxApaterno.BorderColor = borde;
                            val = DeliveryApp.Controladores.RegistrarUsuario.validarApellido(tbxAmaterno.Texts);

                            if (val == 3)
                            {
                                tbxAmaterno.BorderColor = Color.Red;
                                MessageBox.Show("El apellido materno esta vacio");
                                return false;
                            }
                            else
                            {
                                if (val == 0)
                                {
                                    tbxAmaterno.BorderColor = borde;
                                    val = DeliveryApp.Controladores.RegistrarUsuario.validarTelefono(tbxTelefono.Texts);

                                    if (val == 3)
                                    {
                                        tbxTelefono.BorderColor = Color.Red;
                                        MessageBox.Show("El telefono esta vacio");
                                        return false;
                                    }
                                    else
                                    {
                                        if (val == 0)
                                        {
                                            tbxTelefono.BorderColor = borde;
                                            val = DeliveryApp.Controladores.RegistrarUsuario.validarRFC(tbxRFC.Texts);

                                            if (val == 3)
                                            {
                                                tbxRFC.BorderColor = Color.Red;
                                                MessageBox.Show("El RFC esta vacio");
                                                return false;
                                            }
                                            else
                                            {
                                                if (val == 0)
                                                {
                                                    tbxRFC.BorderColor = borde;
                                                    return true;
                                                }
                                                else if (val == 1)
                                                {
                                                    tbxRFC.BorderColor = Color.Red;
                                                    MessageBox.Show("El RFC tiene más de 15 digitos");
                                                    return false;
                                                }
                                                else
                                                {
                                                    tbxRFC.BorderColor = Color.Red;
                                                    MessageBox.Show("El RFC tiene caracteres no validos");
                                                    return false;
                                                }
                                            }
                                        }
                                        else if (val == 1)
                                        {
                                            tbxTelefono.BorderColor = Color.Red;
                                            MessageBox.Show("El telefono tiene más o menos de 10 digitos");
                                            return false;
                                        }
                                        else
                                        {
                                            tbxTelefono.BorderColor = Color.Red;
                                            MessageBox.Show("El telefono tiene caracteres no validos");
                                            return false;
                                        }
                                    }
                                }
                                else if (val == 1)
                                {
                                    tbxAmaterno.BorderColor = Color.Red;
                                    MessageBox.Show("El apellido materno tiene más de 20 caracteres");
                                    return false;
                                }
                                else
                                {
                                    tbxAmaterno.BorderColor = Color.Red;
                                    MessageBox.Show("El apellido materno tiene caracteres no validos");
                                    return false;
                                }
                            }
                        }
                        else if (val == 1)
                        {
                            tbxApaterno.BorderColor = Color.Red;
                            MessageBox.Show("El apellido paterno tiene más de 20 caracteres");
                            return false;
                        }
                        else
                        {
                            tbxApaterno.BorderColor = Color.Red;
                            MessageBox.Show("El apellido paterno tiene caracteres no validos");
                            return false;
                        }
                    }
                }
                else if (val == 1)
                {
                    tbxNombre.BorderColor = Color.Red;
                    MessageBox.Show("El nombre tiene más de 25 caracteres");
                    return false;
                }
                else
                {
                    tbxNombre.BorderColor = Color.Red;
                    MessageBox.Show("El nombre tiene caracteres no validos");
                    return false;
                }
            }
            
        }

        private bool validarFase2()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarNomu(tbxUsuario.Texts);
            
            if(val == 3)
            {
                tbxUsuario.BorderColor = Color.Red;
                MessageBox.Show("El nombre de usuario esta vacio o tiene pocos caracteres");
                return false;
            }
            else
            {
                if(val == 0)
                {
                    tbxUsuario.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarCorreo(tbxCorreo.Texts, tbxConfirmarCorreo.Texts);
                    //correo
                    if (val == 3)
                    {
                        tbxCorreo.BorderColor = Color.Red;
                        MessageBox.Show("El correo esta vacio");
                        return false;
                    }
                    else
                    {
                        if (val == 4)
                        {
                            tbxConfirmarCorreo.BorderColor = Color.Red;
                            MessageBox.Show("Los correos no coinciden");
                            return false;
                        }
                        else
                        {
                            if (val == 0)
                            {
                                tbxCorreo.BorderColor = borde;
                                tbxConfirmarCorreo.BorderColor = borde;
                                val = DeliveryApp.Controladores.RegistrarUsuario.validarContraseña(tbxContraseña.Texts, tbxConfirmarContraseña.Texts);
                                // contraseña

                                if(val == 3)
                                {
                                    tbxContraseña.BorderColor = Color.Red;
                                    MessageBox.Show("La contraseña esta vacia");
                                    return false;
                                }
                                else
                                {
                                    if(val == 4)
                                    {
                                        tbxConfirmarContraseña.BorderColor = Color.Red;
                                        MessageBox.Show("Las contraseñas no coinciden");
                                        return false;
                                    }
                                    else
                                    {
                                        if (val == 0)
                                        {
                                            tbxContraseña.BorderColor = borde;
                                            tbxConfirmarContraseña.BorderColor = borde;
                                            return true;
                                        }
                                        else
                                        {
                                            tbxConfirmarContraseña.BorderColor = Color.Red;
                                            MessageBox.Show("La contraseña tiene más de 30 caracteres");
                                            return false;
                                        }
                                    }
                                }
                            }
                            else if (val == 1)
                            {
                                tbxCorreo.BorderColor = Color.Red;
                                MessageBox.Show("El correo tiene más de 40 caracteres");
                                return false;
                            }
                            else // 2
                            {
                                tbxCorreo.BorderColor = Color.Red;
                                MessageBox.Show("El correo no es valido");
                                return false;
                            }
                        }
                    }
                }
                else if (val == 1)
                {
                    tbxUsuario.BorderColor = Color.Red;
                    MessageBox.Show("El nombre de usuario tiene más de 20 caracteres");
                    return false;
                }
                else
                {
                    tbxUsuario.BorderColor = Color.Red;
                    MessageBox.Show("El nombre de usuario tiene caracteres no validos");
                    return false;
                }
            }

            
        }

        private bool validarFase3()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarCalle(cbxCalle1.Texts);

            // Calle 1
            if (val == 3)
            {
                cbxCalle1.BorderColor = Color.Red;
                MessageBox.Show("La calle 1 esta vacia");
                return false;
            }
            else
            {
                if (val == 0)
                {
                    cbxCalle1.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarCalle(cbxCalle2.Texts);
                    
                    // Calle 2
                    if (val == 3)
                    {
                        cbxCalle2.BorderColor = Color.Red;
                        MessageBox.Show("La calle 2 esta vacia");
                        return false;
                    }
                    else 
                    {
                        if (val == 0)
                        {
                            cbxCalle2.BorderColor = borde;
                            val = DeliveryApp.Controladores.RegistrarUsuario.validarCasa(cbxNumCasa.Texts);

                            // Numero de casa
                            if (val == 3)
                            {
                                cbxNumCasa.BorderColor = Color.Red;
                                MessageBox.Show("El número de casa esta vacio");
                                return false;
                            }
                            else
                            {
                                if (val == 0)
                                {
                                    cbxNumCasa.BorderColor = borde;
                                    return true;
                                }
                                else if (val == 1)
                                {
                                    cbxNumCasa.BorderColor = Color.Red;
                                    MessageBox.Show("El número de casa tiene más de 3 caracteres");
                                    return false;
                                }
                                else
                                {
                                    cbxNumCasa.BorderColor = Color.Red;
                                    MessageBox.Show("El número de casa tiene caracteres no validos");
                                    return false;
                                }
                            }
                        }
                        else if (val == 1)
                        {
                            cbxCalle2.BorderColor = Color.Red;
                            MessageBox.Show("La calle 2 tiene más de 25 caracteres");
                            return false;
                        }
                        else
                        {
                            cbxCalle2.BorderColor = Color.Red;
                            MessageBox.Show("La calle 2 tiene caracteres no validos");
                            return false;
                        }
                    }
                }
                else if (val == 1)
                {
                    cbxCalle1.BorderColor = Color.Red;
                    MessageBox.Show("La calle 1 tiene más de 25 caracteres");
                    return false;
                }
                else
                {
                    cbxCalle1.BorderColor = Color.Red;
                    MessageBox.Show("La calle 1 tiene caracteres no validos");
                    return false;
                }
            }
        }
    }
}
