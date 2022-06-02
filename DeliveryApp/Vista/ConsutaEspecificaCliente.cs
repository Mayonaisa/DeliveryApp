using System;
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
    public partial class ConsutaEspecificaCliente : Form
    {
        Cliente Cli;
        Panel contenedor;
        public ConsutaEspecificaCliente(Panel p, Cliente C)
        {
            Cli = C;
            contenedor = p;
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void ConsutaEspecificaCliente_Load(object sender, EventArgs e)
        {
            txtCliente.Texts = Cli.Nombre;
            txtApa.Texts = Cli.APaterno;
            txtAma.Texts = Cli.AMaterno;
            txtCorreo.Texts = Cli.Correo;
            txtUsu.Texts = Cli.Nomu;
            txtRFC.Texts = Cli.RFC1;

            txtCalle1.Texts = Cli.Dir.Calle1;
            txtCalle2.Texts = Cli.Dir.Calle2;
            txtCiudad.Texts = Cli.Dir.Ciudad;
            txtColonia.Texts = Cli.Dir.Colonia;
            txtNumCasa.Texts = Cli.Dir.NumCasa;
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
        private void rjButton2_Click(object sender, EventArgs e)
        {
            ConsultaGeneralClientes Volver = new ConsultaGeneralClientes(contenedor);
            Desplegar(Volver);
        }
    }
}
