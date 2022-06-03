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
    public partial class RegistrarVehiculo : Form
    {
        Vehiculo veh;
        List<Vehiculo> lve;
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();

        public RegistrarVehiculo(Panel p, Vehiculo V)
        {
            veh = V;
            contenedor = p;
            InitializeComponent();
        }

        private void ConsultaEspecificaVehiculo_Load(object sender, EventArgs e)
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

        private void cbxId_Enter(object sender, EventArgs e)
        {
            //string msg = "";
            //lve = new List<Vehiculo>();
            //ConsultarVehiculos.ObtenerVehiculos(ref lve, ref msg, veh);

            //cbxId.Items.Clear();
            //foreach (Vehiculo v in lve)
            //{
            //    cbxId.Items.Add(v.IdVehiculo);
            //}
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuRecep_Admin ConPro = new MenuRecep_Admin(new Administrador(), contenedor);
            Desplegar(ConPro);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(validar())
            MessageBox.Show(Vehiculo.registrar(tbxMarca.Texts, tbxPlaca.Texts, tbxColor.Texts, tbxAño.Texts, tbxModelo.Texts, tbxTipo.Texts));
        }

        private bool validar()
        {
            if (tbxMarca.Texts != "")
            {
                if (tbxMarca.Texts.Length <= 50)
                {
                    if (Regex.IsMatch(tbxMarca.Texts, @"^[\p{L} \.'\-]+$"))
                    {
                        if (tbxColor.Texts != "")
                        {
                            if (tbxColor.Texts.Length <= 15)
                            {
                                if (Regex.IsMatch(tbxColor.Texts, @"^[\p{L} \.'\-]+$"))
                                {
                                    if (tbxModelo.Texts != "")
                                    {
                                        if (tbxModelo.Texts.Length <= 20)
                                        {
                                            if (Regex.IsMatch(tbxModelo.Texts, @"(^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9])[a-zA-Z0-9]$){0,20}"))
                                            {
                                                if (tbxAño.Texts != "")
                                                {
                                                    if (tbxAño.Texts.Length <= 10)
                                                    {
                                                        if (Regex.IsMatch(tbxAño.Texts, @"(^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9])[a-zA-Z0-9]$){0,20}"))
                                                        {
                                                            if (tbxPlaca.Texts != "")
                                                            {
                                                                if (tbxPlaca.Texts.Length <= 10)
                                                                {
                                                                    if (Regex.IsMatch(tbxPlaca.Texts, @"(^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9])[a-zA-Z0-9]$){0,20}"))
                                                                    {
                                                                        return true;
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("La placa no es valido");
                                                                        return false;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("La placa tiene mas de 10 caracteres");
                                                                    return false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("La placa esta vacia");
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El año no es valido");
                                                            return false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El año tiene mas de 10 caracteres");
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("El año esta vacio");
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El modelo no es valido");
                                                return false;
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("El modelo tiene mas de 20 caracteres");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El modelo esta vacio");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El color no es valido");
                                    return false;
                                }

                            }
                            else
                            {
                                MessageBox.Show("El color tiene mas de 15 caracteres");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El color esta vacio");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La marca no es valido");
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("La marca tiene mas de 50 caracteres");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("La marca esta vacia");
                return false;
            }
        }
    }
}
