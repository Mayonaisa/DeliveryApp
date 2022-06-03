using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Vista
{
    public partial class ReciboCliente : Form
    {
        Panel contenedor;
        public ReciboCliente(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void ReciboCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
