using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;

namespace DeliveryApp.Vista
{
    public partial class ConsultaEspecificaPedidosRecep : Form
    {
        Panel contenedor;
        public ConsultaEspecificaPedidosRecep(Panel p)
        {
            contenedor= p;
            InitializeComponent();
            CustomControls.RJControls.RJButton Boton=new RJButton();
            this.Controls.Add(Boton);
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }
    }
}
