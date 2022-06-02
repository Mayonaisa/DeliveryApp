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
        Vehiculo Veh = new Vehiculo();
        Panel contenedor = new Panel();
        Recepcionista Rep = new Recepcionista();
        string Mensaje;

        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public CatalogoGeneralVehiculos(Recepcionista r, Panel p)
        {
            Rep = r;
            contenedor = p;
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

        private void CatalogoGeneralVehiculos_Load(object sender, EventArgs e)
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
        
        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //metodo que se creara dinamicamente para
            if (e.RowIndex == -1)
            {

            }
            else
            {
                string error = null;
                Veh = new Vehiculo();
                string VehID = null;
                VehID = dgvVehiculo[0, e.RowIndex].Value.ToString().Trim();
                //
                ConsultarVehiculos.VehiculoEspecifico(VehID, ref Veh, ref error);
                ConsultaEspecificaVehiculo ConsultarVehiculo = new ConsultaEspecificaVehiculo(contenedor, Veh);

                if (error != null)
                {
                    MessageBox.Show(error);
                }
                //
                Desplegar(ConsultarVehiculo);
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

    }
}
