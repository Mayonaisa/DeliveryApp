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
        public ConsultaEspecificaEmpleados(Panel p,Recepcionista Rec, Repartidor Rep )
        {
            contenedor = p;
            Repar = Rep;
            Recep = Rec;
            InitializeComponent();
        }

        private void ConsultaEspecificaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
