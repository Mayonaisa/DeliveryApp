using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DeliveryApp.Controladores;
using DeliveryApp.Modelos;

namespace DeliveryApp.Vista
{
    public partial class ReporteVentasTotales : Form
    {
        Panel contenedor;
        List<Cliente> Cli=new List<Cliente>();
        List<VentasTotales> LVT = new List<VentasTotales>();
        public ReporteVentasTotales(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvCliente.CellClick += dgvCliente_CellClick;
        }

        private void Producto_Especifico_Load(object sender, EventArgs e)
        {
            string mensaje=null;
            //VentasTotalesCon.ObtenerClientes(ref Cli, ref mensaje);
            VentasTotalesCon.ObtenerVentas(ref LVT);
            int i = 0;
            while (i <LVT.Count)
            {
                dgvCliente.Rows.Add(LVT[i].IdCliente, LVT[i].Nombre, LVT[i].Monto, LVT[i].CantidadProducto, LVT[i].NombreProducto);
                i++;
            }
            
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            int i = 0;
            while (i < LVT.Count)
            {
                dgvCliente.Rows.Add(LVT[i].IdCliente, LVT[i].Nombre, LVT[i].Monto, LVT[i].CantidadProducto, LVT[i].NombreProducto);
                i++;
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1)
            {
                dgvReporte.Rows.Clear();
                VentasTotales VT = new VentasTotales();
                string id =dgvCliente[0, e.RowIndex].Value.ToString().Trim();
                VentasTotalesCon.ObtenerVentasIndi(id,VT);
                dgvReporte.Rows.Add(VT.IdCliente, VT.Nombre, VT.Monto, VT.CantidadProducto, VT.NombreProducto);
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                //dgvReporte.Visible = true;

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

        private void btnReporte_Click(object sender, EventArgs e)
        {

            
        }
    }
}
