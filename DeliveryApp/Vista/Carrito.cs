﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Recursos;

namespace DeliveryApp.Vista
{
    public partial class Carrito : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        public Carrito(Panel p,CarritoC c)
        {
            contenedor = p;
            Carro = c;
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            MenuCliente MenuClienteV = new MenuCliente(contenedor,Carro);

            this.Hide();
            Desplegar(MenuClienteV);
            this.Close();
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

        private void Carrito_Load(object sender, EventArgs e)
        {
            
        }
    }
}
