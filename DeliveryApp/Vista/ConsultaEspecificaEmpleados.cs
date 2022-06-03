﻿using System;
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
    public partial class ConsultaEspecificaEmpleados : Form
    {
        Repartidor Repar=new Repartidor();
        Recepcionista Recep=new Recepcionista();
        Panel contenedor;
        Color borde = Color.FromArgb(241, 241, 241);
        public ConsultaEspecificaEmpleados(Panel p,Recepcionista Rec )
        {
            contenedor = p;
            Recep = Rec;
            InitializeComponent();
        }
        public ConsultaEspecificaEmpleados(Panel p, Repartidor Rep)
        {
            contenedor = p;
            Repar = Rep;
            InitializeComponent();
        }

        private void ConsultaEspecificaEmpleados_Load(object sender, EventArgs e)
        {
            if (Recep.IdPersona != null)
            {

                txtNom.Texts =Recep.Nombre;
                txtApa.Texts =Recep.APaterno;
                txtAma.Texts = Recep.AMaterno;
                txtCorreo.Texts=Recep.Correo;
                txtUsua.Texts = Recep.Nomu;
                txtCalle1.Texts = Recep.Dir.Calle1;
                txtCalle2.Texts = Recep.Dir.Calle2;
                txtCiudad.Texts=Recep.Dir.Ciudad;
                txtColonia.Texts = Recep.Dir.Colonia;
                txtNumCasa.Texts = Recep.Dir.NumCasa;
            }
            else
            {
                lblCor.Visible= false;
                lblUs.Visible= false;
                txtCorreo.Visible = false;
                txtUsua.Visible = false;

                txtNom.Texts = Repar.Nombre;
                txtApa.Texts = Repar.APaterno;
                txtAma.Texts = Repar.AMaterno;
                txtCalle1.Texts = Repar.Dir.Calle1;
                txtCalle2.Texts = Repar.Dir.Calle2;
                txtCiudad.Texts = Repar.Dir.Ciudad;
                txtColonia.Texts = Repar.Dir.Colonia;
                txtNumCasa.Texts = Repar.Dir.NumCasa;

            }
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
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            /// ACTUALZIAR
            if(validarFase1() && validarFase2() && validarFase3())
            {
                if (Recep.IdPersona != null)
                {

                    string id = Repartidor.actualizarCliente(txtNom.Texts, txtApa.Texts, txtAma.Texts, txtCorreo.Texts, txtCalle1.Texts, txtCalle2.Texts, txtColonia.Texts, txtNumCasa.Texts, txtCiudad.Texts);
                    MessageBox.Show(id);
                }
                else
                {
                    string id = Repartidor.actualizarCliente(txtNom.Texts, txtApa.Texts, txtAma.Texts, txtCorreo.Texts, txtCalle1.Texts, txtCalle2.Texts, txtColonia.Texts, txtNumCasa.Texts, txtCiudad.Texts);
                    MessageBox.Show(id);
                }

                ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
                Desplegar(Volver);
            }
            else
            {
                
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
                                    val = 0;//DeliveryApp.Controladores.RegistrarUsuario.validarTelefono(tbxTelefono.Texts);

                                    if (val == 3)
                                    {
                                        //tbxTelefono.BorderColor = Color.Red;
                                        MessageBox.Show("El telefono esta vacio");
                                        return false;
                                    }
                                    else
                                    {
                                        if (val == 0)
                                        {
                                            //tbxTelefono.BorderColor = borde;

                                            return true;
                                        }
                                        else if (val == 1)
                                        {
                                            //tbxTelefono.BorderColor = Color.Red;
                                            MessageBox.Show("El telefono tiene más o menos de 10 digitos");
                                            return false;
                                        }
                                        else
                                        {
                                            //tbxTelefono.BorderColor = Color.Red;
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

        private bool validarFase2()
        {
            int val = DeliveryApp.Controladores.RegistrarUsuario.validarNomu(txtUsua.Texts);

            if (val == 3)
            {
                txtUsua.BorderColor = Color.Red;
                MessageBox.Show("El nombre de usuario esta vacio o tiene pocos caracteres");
                return false;
            }
            else
            {
                if (val == 0)
                {
                    txtUsua.BorderColor = borde;
                    val = DeliveryApp.Controladores.RegistrarUsuario.validarCorreo(txtCorreo.Texts, txtCorreo.Texts);
                    //correo
                    if (val == 3)
                    {
                        txtCorreo.BorderColor = Color.Red;
                        MessageBox.Show("El correo esta vacio");
                        return false;
                    }
                    else
                    {
                        if (val == 4)
                        {
                            txtCorreo.BorderColor = Color.Red;
                            MessageBox.Show("Los correos no coinciden");
                            return false;
                        }
                        else
                        {
                            if (val == 0)
                            {
                                txtCorreo.BorderColor = borde;
                                txtCorreo.BorderColor = borde;
                                val = 0; //DeliveryApp.Controladores.RegistrarUsuario.validarContraseña(tbxCont.Texts, tbxConfcont.Texts);
                                // contraseña

                                if (val == 3)
                                {
                                    //tbxCont.BorderColor = Color.Red;
                                    MessageBox.Show("La contraseña esta vacia");
                                    return false;
                                }
                                else
                                {
                                    if (val == 4)
                                    {
                                        //tbxConfcont.BorderColor = Color.Red;
                                        MessageBox.Show("Las contraseñas no coinciden");
                                        return false;
                                    }
                                    else
                                    {
                                        if (val == 0)
                                        {
                                            //tbxCont.BorderColor = borde;
                                            //tbxConfcont.BorderColor = borde;
                                            return true;
                                        }
                                        else
                                        {
                                            //tbxConfcont.BorderColor = Color.Red;
                                            MessageBox.Show("La contraseña tiene más de 30 caracteres");
                                            return false;
                                        }
                                    }
                                }
                            }
                            else if (val == 1)
                            {
                                txtCorreo.BorderColor = Color.Red;
                                MessageBox.Show("El correo tiene más de 40 caracteres");
                                return false;
                            }
                            else // 2
                            {
                                txtCorreo.BorderColor = Color.Red;
                                MessageBox.Show("El correo no es valido");
                                return false;
                            }
                        }
                    }
                }
                else if (val == 1)
                {
                    txtUsua.BorderColor = Color.Red;
                    MessageBox.Show("El nombre de usuario tiene más de 20 caracteres");
                    return false;
                }
                else
                {
                    txtUsua.BorderColor = Color.Red;
                    MessageBox.Show("El nombre de usuario tiene caracteres no validos");
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
