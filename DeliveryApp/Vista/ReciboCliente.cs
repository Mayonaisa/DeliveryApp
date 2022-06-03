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
        List<FacturaCliente> FacturasCli;
        public ReciboCliente(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvCliente.CellClick += dgvCliente_CellClick;
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// aqui se generan los datos del cliente que se le hace click
            if (e.RowIndex != -1)
            {
                string id =Facturas[e.RowIndex].IdOrden;
                FacturasCli = new List<FacturaCliente>();
                new ConFactura().Facturar(ref FacturasCli,id);
                decimal total = new FacturaCliente().TotalMonto(FacturasCli,id);
                foreach (FacturaCliente F in FacturasCli)
                {
                    dgvReporte.Rows.Add(F.Cnombre1 + " " + F.Apaterno1 + " " + F.Amaterno1, F.Pnombre1,  F.Cantidad, F.Monto,total, F.RFC1);
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
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataGridView Ticket = dgvReporte;
            Bitmap bmp = new Bitmap(Ticket.Width, Ticket.Height, Ticket.CreateGraphics());
            Ticket.DrawToBitmap(bmp, new Rectangle(0, 0, Ticket.Width, Ticket.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
        }
    }
}
