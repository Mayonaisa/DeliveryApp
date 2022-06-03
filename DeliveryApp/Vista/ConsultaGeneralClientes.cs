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
        Panel contenedor;
        public ConsultaGeneralClientes(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvCliente.CellClick += dgvCliente_CellClick;
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                string error = null;
                string ID = null;
                ID = dgvCliente[0, e.RowIndex].Value.ToString().Trim();

                //if (error != null)
                //{
                //    MessageBox.Show(error);
                //}
                ConsultaClientes.ObtenerClienteIndi(ID, ref Cli);
                ConsutaEspecificaCliente C = new ConsutaEspecificaCliente(contenedor,Cli);
                Desplegar(C);



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
                dgvCliente.Rows.Add(LClientes[i].IdPersona, LClientes[i].Nombre+" "+ LClientes[i].APaterno+" "+ LClientes[i].AMaterno, LClientes[i].Telefono, LClientes[i].Sexo, LClientes[i].Edad, LClientes[i].Dir.Calle1, LClientes[i].Dir.Calle2, LClientes[i].Dir.Colonia, LClientes[i].Dir.NumCasa);
                i++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }

        private void ConsultaGeneralClientes_Load(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            string Mensaje = null;
            int max = 0;
            dgvCliente.Rows.Clear();
            ConsultaClientes.cantidadClientes(ref max, ref Cli);
            ConsultaClientes.ObtenerClientes(ref LClientes, ref Mensaje, Cli);
            int i = 0;
            foreach(Cliente cli in LClientes)
            {
                dgvCliente.Rows.Add(cli.IdPersona, cli.Nombre + " " + cli.APaterno + " " + cli.AMaterno, cli.Telefono, cli.Sexo, cli.Edad, cli.Dir.Calle1, cli.Dir.Calle2, cli.Dir.Colonia, cli.Dir.NumCasa);

            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
