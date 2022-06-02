using DeliveryApp.Controladores;
using DeliveryApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            cbxId.Texts = veh.IdVehiculo;
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
            string msg = "";
            lve = new List<Vehiculo>();
            ConsultarVehiculos.ObtenerVehiculos(ref lve, ref msg, veh);

            cbxId.Items.Clear();
            foreach (Vehiculo v in lve)
            {
                cbxId.Items.Add(v.IdVehiculo);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CatalogoGeneralVehiculos CatVeh = new CatalogoGeneralVehiculos(contenedor);
            Desplegar(CatVeh);
        }

        private void cbxId_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string error = null;
            string VehID = null;

            Vehiculo Veh = new Vehiculo();
            VehID = cbxId.SelectedItem.ToString();

            ConsultarVehiculos.VehiculoEspecifico(VehID, ref Veh, ref error);
            ConsultaEspecificaVehiculo ConsultarVehiculo = new ConsultaEspecificaVehiculo(contenedor, Veh);

            cbxId.Texts = Veh.IdVehiculo;
            tbxAño.Texts = Veh.Año;
            tbxColor.Texts = Veh.Color;
            tbxMarca.Texts = Veh.Marca;
            tbxModelo.Texts = Veh.Modelo;
            tbxPlaca.Texts = Veh.Placa;
            tbxTipo.Texts = Veh.Tipo;
        }
    }
}
