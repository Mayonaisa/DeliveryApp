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
    public partial class CatalogoGeneralVehiculos : Form
    {
        public CatalogoGeneralVehiculos()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvVehiculo.Rows.Clear();
            string Mensaje = null;
            int max = 0;
            dgvVehiculo.Rows.Clear();
            //ConsultaClientes.cantidadClientes(ref max, ref Cli);
            //ConsultaClientes.ObtenerClientes(ref LClientes, ref Mensaje, Cli);
            //int i = 0;
            //while (i < max)
            //{
            //    dgvVehiculo.Rows.Add(LClientes[i].IdPersona, LClientes[i].Nombre + " " + LClientes[i].APaterno + " " + LClientes[i].AMaterno, LClientes[i].Telefono, LClientes[i].Sexo, LClientes[i].Edad, LClientes[i].RFC1, LClientes[i].Dir.Pais, LClientes[i].Dir.Estado, LClientes[i].Dir.Ciudad, LClientes[i].Dir.Calle1, LClientes[i].Dir.Calle2, LClientes[i].Dir.Colonia, LClientes[i].Dir.NumCasa);
            //    i++;
            //}

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
