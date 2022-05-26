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
            if (ContenedorCatalogos.Controls.Count > 0)
            {
                ContenedorCatalogos.Controls.RemoveAt(0);
            }
            ContenedorCatalogos.Width = f.Width;
            ContenedorCatalogos.Height = f.Height;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            ContenedorCatalogos.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        private void panel4_Click(object sender, EventArgs e)
        {
            MenuRecepcionista Men = new MenuRecepcionista(empleado,ContenedorCatalogos);
            //ContenedorCatalogos.Controls.RemoveAt(0);
            Desplegar(Men);

        }

        private void ContenedorCatalogos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
