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
    public partial class ReciboCliente : Form
    {
        Panel contenedor;
        List<FacturaCliente> Facturas;
        public ReciboCliente(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvCliente.CellClick += dgvCliente_CellClick;
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id =Facturas[e.RowIndex].IdOrden;
                List<FacturaCliente> FacturasCli=new List<FacturaCliente>();
                new ConFactura().Facturar(ref FacturasCli,id);
                foreach (FacturaCliente F in FacturasCli)
                {
                    dgvReporte.Rows.Add(F.Cnombre1 + " " + F.Apaterno1 + " " + F.Amaterno1, F.Pnombre1, F.Monto, F.Cantidad);
                }
                

            }
        }
        private void ReciboCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            Facturas = new List<FacturaCliente>();
            new ConFactura().ListaFacturas(ref Facturas);
            foreach (FacturaCliente F in Facturas)
            {
                dgvCliente.Rows.Add(F.Cnombre1+" "+F.Apaterno1+" "+F.Amaterno1, F.Pnombre1,F.Monto,F.Cantidad);
            }
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            Facturas = new List<FacturaCliente>();
            new ConFactura().ListaFacturas(ref Facturas);
            foreach (FacturaCliente F in Facturas)
            {
                dgvCliente.Rows.Add(F.Cnombre1 + " " + F.Apaterno1 + " " + F.Amaterno1, F.Pnombre1, F.Monto, F.Cantidad);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
