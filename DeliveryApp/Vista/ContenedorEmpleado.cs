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
        Administrador Ad;
        Panel contenedor=new Panel();   
        public ContenedorEmpleado(Usuario Emp, Panel p)
        {
            empleado = new Recepcionista(Emp);
            contenedor = p;
            InitializeComponent();
        }
        public ContenedorEmpleado(Usuario Emp, Panel p, Administrador Admin)
        {
            Ad = new Administrador(Emp);
            contenedor = p;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContenedorEmpleado_Load(object sender, EventArgs e)
        {
            DateTime actual = DateTime.Now;
            lblfecha.Text = actual.ToString();
            if (empleado.IdPersona != null)
            {
                MenuRecep Inicio = new MenuRecep(empleado, ContenedorCatalogos);
                ContenedorCatalogos.Width = Inicio.Width;
                ContenedorCatalogos.Height = Inicio.Height;
                //this.AutoSize = true;
                Inicio.FormBorderStyle = FormBorderStyle.None;
                Inicio.TopLevel = false;
                ContenedorCatalogos.Controls.Add(Inicio);
                Inicio.Dock = DockStyle.Fill;
                Inicio.Show();
            }
            else if (Ad.IdPersona != null)
            {
                MenuRecep_Admin Inicio = new MenuRecep_Admin(Ad, ContenedorCatalogos);
                ContenedorCatalogos.Width = Inicio.Width;
                ContenedorCatalogos.Height = Inicio.Height;
                //this.AutoSize = true;
                Inicio.FormBorderStyle = FormBorderStyle.None;
                Inicio.TopLevel = false;
                ContenedorCatalogos.Controls.Add(Inicio);
                Inicio.Dock = DockStyle.Fill;
                Inicio.Show();
            }




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
            
            

        }

        private void ContenedorCatalogos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (empleado.IdPersona != null)
            {
                MenuRecep Men = new MenuRecep(empleado, ContenedorCatalogos);
                Desplegar(Men);
            }
            else if (Ad.IdPersona != null)
            {
                MenuRecep_Admin Men = new MenuRecep_Admin(Ad, ContenedorCatalogos);
                Desplegar(Men);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            PantallaInicio Inicio = new PantallaInicio(contenedor);
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }
            contenedor.Width = Inicio.Width;
            contenedor.Height = Inicio.Height;
            Inicio.FormBorderStyle = FormBorderStyle.None;
            Inicio.TopLevel = false;
            contenedor.Controls.Add(Inicio);
            Inicio.Dock = DockStyle.Fill;
            Inicio.Show();

        }
    }
}
