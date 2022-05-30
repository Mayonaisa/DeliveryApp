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
        Cliente Cli=new Cliente();
        List<Cliente> LClientes=new List<Cliente>();
        public ConsultaGeneralClientes()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            string Mensaje=null;
            int max = 0;
            dgvCliente.Rows.Clear();
            ConsultaClientes.cantidadClientes(ref max,ref Cli);
            ConsultaClientes.ObtenerClientes(ref LClientes,ref Mensaje,Cli);
            int i = 0;
            while (i < max)
            {
                dgvCliente.Rows.Add(LClientes[i].IdPersona, LClientes[i].Nombre+" "+ LClientes[i].APaterno+" "+ LClientes[i].AMaterno, LClientes[i].Telefono, LClientes[i].Sexo, LClientes[i].Edad, LClientes[i].RFC1);
                i++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
