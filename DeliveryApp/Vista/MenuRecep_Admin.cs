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
    public partial class MenuRecep_Admin : Form
    {
        Administrador recepcionista;
        Panel contenedor=new Panel();
        public MenuRecep_Admin(Administrador Rep, Panel p)
        {
            recepcionista = Rep;
            contenedor = p;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            //PedidosPendientes PedPen = new PedidosPendientes(recepcionista,contenedor);
            //Desplegar(PedPen);

        }

        private void btnEmpleados_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //PedidosPendientes PedPen = new PedidosPendientes(recepcionista, contenedor);
            //Desplegar(PedPen);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultaGeneralEmpleado ConEmp = new ConsultaGeneralEmpleado(contenedor);
            Desplegar(ConEmp);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ConsultaEspecificaDetalle CatDetPed = new ConsultaEspecificaDetalle(contenedor);
            Desplegar(CatDetPed);
        }

        private void pbxEmp_Click(object sender, EventArgs e)
        {
            //PedidosPendientes PedPen = new PedidosPendientes(recepcionista, contenedor);
            //Desplegar(PedPen);
        }

        private void pbxEmp_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ConsultaGeneralClientes ConClin = new ConsultaGeneralClientes(contenedor);
            Desplegar(ConClin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatalogoGeneralVehiculos CatVeh = new CatalogoGeneralVehiculos(contenedor);
            Desplegar(CatVeh);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaGeneralProductos ConPro = new ConsultaGeneralProductos(recepcionista, contenedor);
            Desplegar(ConPro);
        }

        private void MenuRecep_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            PedidosAdmin ConPro = new PedidosAdmin(null, contenedor);
            Desplegar(ConPro);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RegistrarRecepcionista ConPro = new RegistrarRecepcionista(contenedor, new Recepcionista());
            Desplegar(ConPro);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RegistrarRepartidor ConPro = new RegistrarRepartidor(contenedor, new Recepcionista());
            Desplegar(ConPro);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RegistrarAdministrador ConPro = new RegistrarAdministrador(contenedor, new Recepcionista());
            Desplegar(ConPro);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RegistrarProducto ConPro = new RegistrarProducto(contenedor, new Administrador(), "");
            Desplegar(ConPro);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo ConPro = new RegistrarVehiculo(contenedor, new Vehiculo());
            Desplegar(ConPro);
        }
    }
}
