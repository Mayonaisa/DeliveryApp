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
    public partial class ReporteVentasGeneralesPeriodo : Form
    {
        Panel contenedor;
        public ReporteVentasGeneralesPeriodo(Panel p)
        {
            contenedor = p;
            InitializeComponent();
        }

        private void ReporteVentasGeneralesPeriodo_Load(object sender, EventArgs e)
        {
            dpkPeriodoFinal.MinDate = dpkPeriodo.Value.Date;
            dgvReporte.Rows.Clear();
            string inicial = null;
            string final = null;
            DateTime DInicial = dpkPeriodo.Value.Date;
            DateTime DFinal = dpkPeriodoFinal.Value.Date;

            inicial = DInicial.ToString("yyyy-MM-dd");
            final = DFinal.ToString("yyyy-MM-dd");
            Ventas V=new Ventas();
            VentasTotalesCon.ReporteVentasPeriodo(V,inicial,final);
            dgvCliente.Rows.Add(V.Ptotales1, V.Ganancias1, V.PVendidos1, V.Producto, V.Cantidad);



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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dgvReporte.Rows.Clear();
            dgvCliente.Rows.Clear();
            string inicial = null;
            string final = null;
            DateTime DInicial = dpkPeriodo.Value.Date;
            DateTime DFinal = dpkPeriodoFinal.Value.Date;

            inicial = DInicial.ToString("yyyy-MM-dd");
            final = DFinal.ToString("yyyy-MM-dd");
            Ventas V = new Ventas();
            VentasTotalesCon.ReporteVentasPeriodo(V, inicial, final);
            dgvCliente.Rows.Add(V.Ptotales1, V.Ganancias1, V.PVendidos1, V.Producto, V.Cantidad);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dgvReporte.Rows.Clear();
            string inicial = null;
            string final = null;
            DateTime DInicial = dpkPeriodo.Value.Date;
            DateTime DFinal = dpkPeriodoFinal.Value.Date;

            inicial = DInicial.ToString("yyyy-MM-dd");
            final = DFinal.ToString("yyyy-MM-dd");
            Ventas V = new Ventas();
            VentasTotalesCon.ReporteVentasPeriodo(V, inicial, final);
            dgvReporte.Rows.Add(V.Ptotales1, V.Ganancias1, V.PVendidos1, V.Producto, V.Cantidad);

            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
        }
    }
}
