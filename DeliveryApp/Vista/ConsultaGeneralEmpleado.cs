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
    public partial class ConsultaGeneralEmpleado : Form
    {
        List<Recepcionista> LRecep = new List<Recepcionista>();
        Recepcionista Recep=new Recepcionista();
        Repartidor Rep=new Repartidor();
        List<Repartidor> LRep=new List<Repartidor>();

        public ConsultaGeneralEmpleado()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }
    }
}
