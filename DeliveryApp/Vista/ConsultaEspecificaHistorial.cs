using DeliveryApp.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Vista
{
    public partial class ConsultaEspecificaHistorial : Form
    {
        Panel contenedor = new Panel();
        CarritoC Carro = new CarritoC();
        string idOrden = "";
        string fech = "";

        public ConsultaEspecificaHistorial(Panel p, CarritoC c, string id,string fecha)
        {
            contenedor = p;
            Carro = c;
            idOrden = id;
            fech = fecha;
            InitializeComponent();
        }

        private void ConsultaEspecificaHistorial_Load(object sender, EventArgs e)
        {
            Carro.consultaHistorial(idOrden);
            txtNomCliente.Texts = Carro.nombreCliente; //el nombre del cliente
            txtDirCliente.Texts = Carro.direccion;
            txtNomRep.Texts = Carro.nombreRepartidor;
            txtNomRec.Texts = Carro.nombreRec;

            int y = 0;
            bool t = true;
            Carro.consultaEsp(idOrden,t); //esto ejecuta un método que devuelve los valores por producto, osea, la lista de productos, su precio y cantidad (idOrden ya lo tienes, está arriba) ejecuta t como true para sacar eso
            for(int n = 0; n < Carro.nombreProd.Count; n++)
            {
                PanelProducto prueba = new PanelProducto(Carro);
                prueba.Crear_Panel_consulta(Carro.nombreProd[n], Carro.monto[n], Carro.cantidad[n], 0, y);//esos son los datos de nombre del producto, monto y cantidad según su indice en un listas
                this.pnlHistorial.Controls.Add(prueba);
                y += 82;
            }
            t = false;
            Carro.consultaEsp(idOrden, t); //por otro lado, si ejecutas t como false te devuelve el monto total en el la lista monto indice 0 (monto[0])
            PanelProducto prueba2 = new PanelProducto(Carro);
            prueba2.Crear_Panel_consulta("Total pagado:", Carro.monto[0], "", pnlHistorial.Location.X, (pnlHistorial.Location.Y)+pnlHistorial.Height + 40);
            this.Controls.Add(prueba2);
            prueba2.BRcantidad.Hide();


            t = true;
            Carro.consultaEsp(idOrden, t);
            y = 5;
            Label nom = new Label();
            nom.Text = "DelivaryApp";
            nom.Location = new Point((pnlRecibo.Width/2)-(nom.Width/2), y);
            y += 25;
            Label fe = new Label();
            fe.Text = fech;
            fe.Location = new Point((pnlRecibo.Width / 2) - (fe.Width / 2), y);
            y += 25;
            Label nombre = new Label();
            nombre.Text = "Nombre del cliente";
            nombre.Location = new Point(5,y);
            y += 15;
            nombre.Width = 200;
            Label nombre2 = new Label();
            nombre2.Text = Carro.nombreCliente;
            nombre2.Location = new Point(5, y);
            nombre2.Width = 400;
            y += 25;
            for (int n = 0; n < Carro.nombreProd.Count; n++)
            {
                Label cont = new Label();
                cont.Text = Carro.nombreProd[n] + "     monto: $" + Carro.monto[n] + "     Cantidad:" + Carro.cantidad[n];
                cont.Location = new Point(5, y);
                cont.Width = 400;
                y += 15;
                pnlRecibo.Controls.Add(cont);
            }

            y += 15;
            t = false;
            Carro.consultaEsp(idOrden, t);
            Label final = new Label();
            final.Text = "Total pagado:      $" + Carro.monto[0];
            final.Width = 200;
            final.Location = new Point(5, y);

            pnlRecibo.Controls.Add(final);
            pnlRecibo.Controls.Add(nombre);
            pnlRecibo.Controls.Add(fe);
            pnlRecibo.Controls.Add(nom);
            pnlRecibo.Controls.Add(nombre2);

            pnlRecibo.Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {
            HistorialPedidos HistorialV = new HistorialPedidos(contenedor, Carro);

            this.Hide();
            Desplegar(HistorialV);
            this.Close();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
            //doc.Print();
        }





        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = pnlRecibo;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
    }
}
