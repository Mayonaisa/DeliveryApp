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
    public partial class ConsultaEspecificaVehiculo : Form
    {
        Vehiculo veh;
        List<Vehiculo> lve;
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();

        public ConsultaEspecificaVehiculo(Panel p, Vehiculo V)
        {
            veh = V;
            contenedor = p;
            InitializeComponent();
        }

        private void ConsultaEspecificaVehiculo_Load(object sender, EventArgs e)
        {
            tbxId.Texts = veh.IdVehiculo;
            tbxAño.Texts = veh.Año;
            tbxColor.Texts = veh.Color;
            tbxMarca.Texts = veh.Marca;
            tbxModelo.Texts = veh.Modelo;
            tbxPlaca.Texts = veh.Placa;
            tbxTipo.Texts = veh.Tipo;
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
            CatalogoGeneralVehiculos CatVeh = new CatalogoGeneralVehiculos(contenedor);
            Desplegar(CatVeh);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(tbxColor.Texts != "")
            {
                if (tbxColor.Texts.Length <= 15)
                {
                    if (Regex.IsMatch(tbxColor.Texts, @"^[\p{L} \.'\-]+$"))
                        {
                            MessageBox.Show(Vehiculo.actualizarCliente(tbxId.Texts, tbxTipo.Texts, tbxMarca.Texts, tbxPlaca.Texts, tbxColor.Texts, tbxModelo.Texts, tbxAño.Texts));
                            CatalogoGeneralVehiculos CatVeh = new CatalogoGeneralVehiculos(contenedor);
                            Desplegar(CatVeh);
                        }
                        else
                        {
                            MessageBox.Show("El color no es valido");
                        }
                    
                }
                else
                {
                    MessageBox.Show("El color tiene mas de 15 caracteres");
                }
            }
            else
            {
                MessageBox.Show("El color esta vacio");
            }
        }
    }
}
