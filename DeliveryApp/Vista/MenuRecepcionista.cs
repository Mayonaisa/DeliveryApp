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
    public partial class MenuRecepcionista : Form
    {
        Recepcionista recepcionista;
        public MenuRecepcionista(Recepcionista Rep)
        {
            recepcionista = Rep;    
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new LoginUsuario().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PedidosEntrantes PedEnt = new PedidosEntrantes(recepcionista);
            PedEnt.ShowDialog();
            this.Close();
        }
    }
}
