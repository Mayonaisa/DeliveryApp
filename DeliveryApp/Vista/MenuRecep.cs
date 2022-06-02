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
    public partial class MenuRecep : Form
    {
        Recepcionista recepcionista;
        Panel contenedor = new Panel();
        public MenuRecep(Recepcionista Rep, Panel p)
        {
            recepcionista = Rep;
            contenedor = p;
            InitializeComponent();
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
        private void MenuRecep_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            PedidosPendientes PedPen = new PedidosPendientes(recepcionista, contenedor);
            Desplegar(PedPen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaGeneralProductos ConPro = new ConsultaGeneralProductos(contenedor);
            Desplegar(ConPro);
        }
    }
}
