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
    public partial class ReporteVentasGenerales : Form
    {
        Panel contenedor;
        public ReporteVentasGenerales(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void ReporteVentasGenerales_Load(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            dgvReporte.Rows.Clear();
            Ventas V=new Ventas();
            VentasTotalesCon.ReporteVentas(V);
            dgvCliente.Rows.Add(V.Ptotales1,V.Ganancias1,V.PVendidos1,V.Producto,V.Cantidad);
            dgvReporte.Rows.Add(V.Ptotales1, V.Ganancias1, V.PVendidos1, V.Producto, V.Cantidad);

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
            
        }

        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
        }
    }
}
