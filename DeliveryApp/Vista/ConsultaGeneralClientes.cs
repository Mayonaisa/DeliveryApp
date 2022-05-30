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
    public partial class ConsultaGeneralClientes : Form
    {
        Cliente Cli;
        List<Cliente> LClientes;
        public ConsultaGeneralClientes()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string Mensaje=null;
            dgvCliente.Rows.Clear();



            int cantidad = 0;
            ConsultarPedido.cantidadPedidos(ref cantidad);

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
