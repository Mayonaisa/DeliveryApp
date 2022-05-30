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
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class CatalogoGeneralVehiculos : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        Vehiculo Veh = new Vehiculo();
        public CatalogoGeneralVehiculos()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvVehiculo.Rows.Clear();
            string Mensaje = null;
            int max = Veh.cantidad();
            ConsultarVehiculos.ObtenerVehiculos(ref vehiculos, ref Mensaje, Veh);
            int i = 0;
            while (i < max)
            {
                dgvVehiculo.Rows.Add(vehiculos[i].IdVehiculo, vehiculos[i].Marca, vehiculos[i].Modelo, vehiculos[i].Color, vehiculos[i].Placa, vehiculos[i].Año, vehiculos[i].Tipo);
                i++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
