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
    public partial class ConsultaEspecificaEmpleados : Form
    {
        Repartidor Repar=new Repartidor();
        Recepcionista Recep=new Recepcionista();
        Panel contenedor;
        public ConsultaEspecificaEmpleados(Panel p,Recepcionista Rec )
        {
            contenedor = p;
            Recep = Rec;
            InitializeComponent();
        }
        public ConsultaEspecificaEmpleados(Panel p, Repartidor Rep)
        {
            contenedor = p;
            Repar = Rep;
            InitializeComponent();
        }

        private void ConsultaEspecificaEmpleados_Load(object sender, EventArgs e)
        {
            if (Recep.IdPersona != null)
            {

                txtNom.Texts =Recep.Nombre;
                txtApa.Texts =Recep.APaterno;
                txtAma.Texts = Recep.AMaterno;
                txtCorreo.Texts=Recep.Correo;
                txtUsua.Texts = Recep.Nomu;
                txtCalle1.Texts = Recep.Dir.Calle1;
                txtCalle2.Texts = Recep.Dir.Calle2;
                txtCiudad.Texts=Recep.Dir.Ciudad;
                txtColonia.Texts = Recep.Dir.Colonia;
                txtNumCasa.Texts = Recep.Dir.NumCasa;
            }
            else
            {
                lblCor.Visible= false;
                lblUs.Visible= false;
                txtCorreo.Visible = false;
                txtUsua.Visible = false;

                txtNom.Texts = Repar.Nombre;
                txtApa.Texts = Repar.APaterno;
                txtAma.Texts = Repar.AMaterno;
                txtCalle1.Texts = Repar.Dir.Calle1;
                txtCalle2.Texts = Repar.Dir.Calle2;
                txtCiudad.Texts = Repar.Dir.Ciudad;
                txtColonia.Texts = Repar.Dir.Colonia;
                txtNumCasa.Texts = Repar.Dir.NumCasa;

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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado Volver = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(Volver);
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            /// ACTUALZIAR

            if (Recep.IdPersona != null)
            {

                string id = Repartidor.actualizarCliente(txtNom.Texts, txtApa.Texts, txtAma.Texts, txtCorreo.Texts, txtCalle1.Texts, txtCalle2.Texts, txtColonia.Texts, txtNumCasa.Texts, txtCiudad.Texts);
                MessageBox.Show(id);
            }
            else
            {
                string id = Repartidor.actualizarCliente(txtNom.Texts, txtApa.Texts, txtAma.Texts, txtCorreo.Texts, txtCalle1.Texts, txtCalle2.Texts, txtColonia.Texts, txtNumCasa.Texts, txtCiudad.Texts);
                MessageBox.Show(id);
            }

            ConsultaGeneralClientes Volver = new ConsultaGeneralClientes(contenedor);
            Desplegar(Volver);
        }
    }
}
