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
    }
}
