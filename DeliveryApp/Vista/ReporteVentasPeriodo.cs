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
    public partial class ReporteVentasPeriodo : Form
    {
        Panel contenedor;
        List<Cliente> Cli = new List<Cliente>();
        List<VentasTotales> LVT;
        public ReporteVentasPeriodo(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvCliente.CellClick += dgvCliente_CellClick;
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id = dgvCliente[0, e.RowIndex].Value.ToString().Trim();
                string inicial = null;
                string final = null;
                VentasTotales VentasT = new VentasTotales();
                //string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
                DateTime DInicial = dpkPeriodo.Value.Date;
                DateTime DFinal = dpkPeriodoFinal.Value.Date;

                inicial = DInicial.ToString("yyyy-MM-dd");
                final = DFinal.ToString("yyyy-MM-dd");

                VentasTotalesCon.ObtenerVentasIndiPeriodo(id,VentasT, inicial, final);
                dgvReporte.Rows.Add(VentasT.IdCliente, VentasT.Nombre, VentasT.Monto, VentasT.CantidadProducto, VentasT.NombreProducto);

            }
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

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //string mensaje = null;
            //VentasTotalesCon.ObtenerVentas(ref LVT);
            //int i = 0;
            //while (i < LVT.Count)
            //{
            //    dgvCliente.Rows.Add(LVT[i].IdCliente, LVT[i].Nombre, LVT[i].Monto, LVT[i].CantidadProducto, LVT[i].NombreProducto);
            //    i++;
            //}
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            dpkPeriodoFinal.MinDate = dpkPeriodo.Value;
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            dgvReporte.Rows.Clear();
        }

        private void ReporteVentasPeriodo_Load(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            string mensaje = null;
            dpkPeriodoFinal.MinDate = dpkPeriodo.Value.Date;
            string inicial = null;
            string final = null;
            LVT = new List<VentasTotales>();
            //string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
            DateTime DInicial=dpkPeriodo.Value.Date;
            DateTime DFinal= dpkPeriodoFinal.Value.Date;

            inicial = DInicial.ToString("yyyy-MM-dd");
            final = DFinal.ToString("yyyy-MM-dd");

            VentasTotalesCon.ObtenerVentasPeriodo(ref LVT,inicial,final);
            int i = 0;
            while (i < LVT.Count)
            {
                dgvCliente.Rows.Add(LVT[i].IdCliente, LVT[i].Nombre, LVT[i].Monto, LVT[i].CantidadProducto, LVT[i].NombreProducto);
                i++;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            string mensaje = null;
            dpkPeriodoFinal.MinDate = dpkPeriodo.Value.Date;
            string inicial = null;
            string final = null;
            LVT = new List<VentasTotales>();
            //string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
            DateTime DInicial = dpkPeriodo.Value.Date;
            DateTime DFinal = dpkPeriodoFinal.Value.Date;

            inicial = DInicial.ToString("yyyy-MM-dd");
            final = DFinal.ToString("yyyy-MM-dd");

            VentasTotalesCon.ObtenerVentasPeriodo(ref LVT, inicial, final);
            int i = 0;
            while (i < LVT.Count)
            {
                dgvCliente.Rows.Add(LVT[i].IdCliente, LVT[i].Nombre, LVT[i].Monto, LVT[i].CantidadProducto, LVT[i].NombreProducto);
                i++;
            }
        }
    }
}
