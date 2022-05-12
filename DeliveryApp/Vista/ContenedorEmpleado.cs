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
using DeliveryApp.Vista;
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class ContenedorEmpleado : Form
    {
        Recepcionista empleado = new Recepcionista();
        Panel contenedor=new Panel();   
        public ContenedorEmpleado(Usuario Emp, Panel p)
        {
            empleado = new Recepcionista(Emp);
            contenedor = p;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContenedorEmpleado_Load(object sender, EventArgs e)
        {
            MenuRecepcionista Inicio = new MenuRecepcionista(empleado,ContenedorCatalogos);
            ContenedorCatalogos.Width = Inicio.Width;
            ContenedorCatalogos.Height = Inicio.Height;
            //this.AutoSize = true;
            Inicio.FormBorderStyle = FormBorderStyle.None;
            Inicio.TopLevel = false;
            ContenedorCatalogos.Controls.Add(Inicio);
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();


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
