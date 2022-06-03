using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;
using DeliveryApp.Controladores;

namespace DeliveryApp.Vista
{
    public partial class RegistrarRepartidor : Form
    {
        Repartidor Repar=new Repartidor();
        Recepcionista Recep=new Recepcionista();
        Panel contenedor;
        Color borde = Color.FromArgb(241, 241, 241);

        public RegistrarRepartidor(Panel p,Recepcionista Rec )
        {
            contenedor = p;
            Recep = Rec;
            InitializeComponent();
        }
        public RegistrarRepartidor(Panel p, Repartidor Rep)
        {
            contenedor = p;
            Repar = Rep;
            InitializeComponent();
        }

        private void ConsultaEspecificaEmpleados_Load(object sender, EventArgs e)
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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuRecep_Admin Volver = new MenuRecep_Admin(new Administrador(), contenedor);
            Desplegar(Volver);
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dtpNacim.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            if (validarFase1() && validarFase3())
            {
                MessageBox.Show(Repartidor.registrar(txtNom.Texts, txtApa.Texts, txtAma.Texts, tbxTelefono.Texts, dtpNacim.Value.ToString(), cbxSexo.Texts, age.ToString(), cbxpais.Texts, cbxestado.Texts, cbxciudad.Texts, txtCalle1.Texts, txtCalle2.Texts, cbxcolonia.Texts, txtNumCasa.Texts));
            }
        }


        private bool validarFase1()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarNombre(txtNom.Texts);

            if (val == 3)
            {
                txtNom.BorderColor = Color.Red;
                MessageBox.Show("El nombre esta vacio");
                return false;
            }
            else
            {
                if (val == 0)
                {
                    txtNom.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarApellido(txtApa.Texts);

                    if (val == 3)
                    {
                        txtApa.BorderColor = Color.Red;
                        MessageBox.Show("El apellido paterno esta vacio");
                        return false;
                    }
                    else
                    {
                        if (val == 0)
                        {
                            txtApa.BorderColor = borde;
                            val = DeliveryApp.Controladores.RegistrarUsuario.validarApellido(txtAma.Texts);

                            if (val == 3)
                            {
                                txtAma.BorderColor = Color.Red;
                                MessageBox.Show("El apellido materno esta vacio");
                                return false;
                            }
                            else
                            {
                                if (val == 0)
                                {
                                    txtAma.BorderColor = borde;
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

                                            return true;
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
                                    txtAma.BorderColor = Color.Red;
                                    MessageBox.Show("El apellido materno tiene más de 20 caracteres");
                                    return false;
                                }
                                else
                                {
                                    txtAma.BorderColor = Color.Red;
                                    MessageBox.Show("El apellido materno tiene caracteres no validos");
                                    return false;
                                }
                            }
                        }
                        else if (val == 1)
                        {
                            txtApa.BorderColor = Color.Red;
                            MessageBox.Show("El apellido paterno tiene más de 20 caracteres");
                            return false;
                        }
                        else
                        {
                            txtApa.BorderColor = Color.Red;
                            MessageBox.Show("El apellido paterno tiene caracteres no validos");
                            return false;
                        }
                    }
                }
                else if (val == 1)
                {
                    txtNom.BorderColor = Color.Red;
                    MessageBox.Show("El nombre tiene más de 25 caracteres");
                    return false;
                }
                else
                {
                    txtNom.BorderColor = Color.Red;
                    MessageBox.Show("El nombre tiene caracteres no validos");
                    return false;
                }
            }

        }

        private bool validarFase3()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarCalle(txtCalle1.Texts);

            // Calle 1
            if (val == 3)
            {
                txtCalle1.BorderColor = Color.Red;
                MessageBox.Show("La calle 1 esta vacia");
                return false;
            }
            else
            {
                if (val == 0)
                {
                    txtCalle1.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarCalle(txtCalle2.Texts);

                    // Calle 2
                    if (val == 3)
                    {
                        txtCalle2.BorderColor = Color.Red;
                        MessageBox.Show("La calle 2 esta vacia");
                        return false;
                    }
                    else
                    {
                        if (val == 0)
                        {
                            txtCalle2.BorderColor = borde;
                            val = DeliveryApp.Controladores.RegistrarUsuario.validarCasa(txtNumCasa.Texts);

                            // Numero de casa
                            if (val == 3)
                            {
                                txtNumCasa.BorderColor = Color.Red;
                                MessageBox.Show("El número de casa esta vacio");
                                return false;
                            }
                            else
                            {
                                if (val == 0)
                                {
                                    txtNumCasa.BorderColor = borde;
                                    return true;
                                }
                                else if (val == 1)
                                {
                                    txtNumCasa.BorderColor = Color.Red;
                                    MessageBox.Show("El número de casa tiene más de 3 caracteres");
                                    return false;
                                }
                                else
                                {
                                    txtNumCasa.BorderColor = Color.Red;
                                    MessageBox.Show("El número de casa tiene caracteres no validos");
                                    return false;
                                }
                            }
                        }
                        else if (val == 1)
                        {
                            txtCalle2.BorderColor = Color.Red;
                            MessageBox.Show("La calle 2 tiene más de 25 caracteres");
                            return false;
                        }
                        else
                        {
                            txtCalle2.BorderColor = Color.Red;
                            MessageBox.Show("La calle 2 tiene caracteres no validos");
                            return false;
                        }
                    }
                }
                else if (val == 1)
                {
                    txtCalle1.BorderColor = Color.Red;
                    MessageBox.Show("La calle 1 tiene más de 25 caracteres");
                    return false;
                }
                else
                {
                    txtCalle1.BorderColor = Color.Red;
                    MessageBox.Show("La calle 1 tiene caracteres no validos");
                    return false;
                }
            }
        }
    }
}
