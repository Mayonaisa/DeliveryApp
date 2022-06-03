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
    public partial class ConsultaGeneralEmpleado : Form
    {
        List<Recepcionista> LRecep = new List<Recepcionista>();
        Recepcionista Recep=new Recepcionista();
        Repartidor Rep=new Repartidor();
        List<Repartidor> LRep=new List<Repartidor>();
        Panel contenedor;

        public ConsultaGeneralEmpleado(Panel p)
        {
            contenedor = p;
            InitializeComponent();
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
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
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                string error = null;
                string ID = null;
                ID = dgvEmpleados[0, e.RowIndex].Value.ToString().Trim();

                //if (error != null)
                //{
                //    MessageBox.Show(error);
                //}
                if (dgvEmpleados[5, e.RowIndex].Value.ToString().Trim()== "Recepcionista")
                {
                    ConsultarEmpleados.ObtenerRecepIndi(ID,ref Recep);
                    ConsultaEspecificaEmpleados Emp = new ConsultaEspecificaEmpleados(contenedor, Recep);
                    Desplegar(Emp);
                }
                if (dgvEmpleados[5, e.RowIndex].Value.ToString().Trim() == "Repartidor")
                {
                    ConsultarEmpleados.ObtenerRepaIndi(ID, ref Rep);
                    ConsultaEspecificaEmpleados EmpREP = new ConsultaEspecificaEmpleados(contenedor,  Rep);
                    Desplegar(EmpREP);
                }
                
                
                
            }
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            string Mensaje = null;
            int max1 = Recep.cantidad();
            int max2 = Rep.cantidad();
            ConsultarEmpleados.CantidadRepartidores(ref max2,ref Rep);
            ConsultarEmpleados.CantidadRecepcionistas(ref max1, ref Recep);

            ConsultarEmpleados.ObtenerRecepcionistas(ref LRecep,ref Mensaje, Recep);
            ConsultarEmpleados.ObtenerRepartidores(ref LRep, ref Mensaje, Rep);

            int i = 0;
            int a = 0;
            while (i < max1)
            {
                dgvEmpleados.Rows.Add(LRecep[i].IdPersona, LRecep[i].Nombre + " " + LRecep[i].APaterno + " " + LRecep[i].AMaterno, LRecep[i].Telefono, LRecep[i].Sexo, LRecep[i].Edad,"Recepcionista");
                i++;
            }
            while (a < max2)
            {
                dgvEmpleados.Rows.Add(LRep[a].IdPersona, LRep[a].Nombre + " " + LRep[a].APaterno + " " + LRep[a].AMaterno, LRep[a].Telefono, LRep[a].Sexo, LRep[a].Edad, "Repartidor");
                a++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }

        private void ConsultaGeneralEmpleado_Load(object sender, EventArgs e)
        {
            cbDis.SelectedIndex = 0;
            cbPre.SelectedIndex = 0;

            dgvEmpleados.Rows.Clear();
            string Mensaje = null;
            int max1 = Recep.cantidad();
            int max2 = Rep.cantidad();
            ConsultarEmpleados.CantidadRepartidores(ref max2, ref Rep);
            ConsultarEmpleados.CantidadRecepcionistas(ref max1, ref Recep);

            ConsultarEmpleados.ObtenerRecepcionistas(ref LRecep, ref Mensaje, Recep);
            ConsultarEmpleados.ObtenerRepartidores(ref LRep, ref Mensaje, Rep);

            int i = 0;
            int a = 0;
            while (i < max1)
            {
                dgvEmpleados.Rows.Add(LRecep[i].IdPersona, LRecep[i].Nombre + " " + LRecep[i].APaterno + " " + LRecep[i].AMaterno, LRecep[i].Telefono, LRecep[i].Sexo, LRecep[i].Edad, "Recepcionista");
                i++;
            }
            while (a < max2)
            {
                dgvEmpleados.Rows.Add(LRep[a].IdPersona, LRep[a].Nombre + " " + LRep[a].APaterno + " " + LRep[a].AMaterno, LRep[a].Telefono, LRep[a].Sexo, LRep[a].Edad, "Repartidor");
                a++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
            /////////////////////
            
            //y = 5;
            //Label nom = new Label();
            //nom.Text = "DelivaryApp";
            //nom.Location = new Point((pnlRecibo.Width / 2) - (nom.Width / 2), y);
            //y += 25;
            //Label fe = new Label();
            //fe.Text = fech;
            //fe.Location = new Point((pnlRecibo.Width / 2) - (fe.Width / 2), y);
            //y += 25;
            //Label nombre = new Label();
            //nombre.Text = "Nombre del cliente";
            //nombre.Location = new Point(5, y);
            //y += 15;
            //nombre.Width = 200;
            //Label nombre2 = new Label();
            //nombre2.Text = Carro.nombreCliente;
            //nombre2.Location = new Point(5, y);
            //nombre2.Width = 400;
            //y += 25;
            //for (int n = 0; n < Carro.nombreProd.Count; n++)
            //{
            //    Label cont = new Label();
            //    cont.Text = Carro.nombreProd[n] + "     monto: $" + Carro.monto[n] + "     Cantidad:" + Carro.cantidad[n];
            //    cont.Location = new Point(5, y);
            //    cont.Width = 400;
            //    y += 15;
            //    pnlRecibo.Controls.Add(cont);
            //}

            //y += 15;
            //t = false;
            //Carro.consultaEsp(idOrden, t);
            //Label final = new Label();
            //final.Text = "Total pagado:      $" + Carro.monto[0];
            //final.Width = 200;
            //final.Location = new Point(5, y);

            //pnlRecibo.Controls.Add(final);
            //pnlRecibo.Controls.Add(nombre);
            //pnlRecibo.Controls.Add(fe);
            //pnlRecibo.Controls.Add(nom);
            //pnlRecibo.Controls.Add(nombre2);

            //pnlRecibo.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            dgvTicket.Rows.Clear();
            dgvReporte.Rows.Clear();
            List<RepEmpleados> repEmpleados = new List<RepEmpleados>();
            if (rbtnRecepMes.Checked)
            {
                
                int Registros=0;
                new ReporteEmpleados().ReporteRecepcionista(ref repEmpleados);
                int i = 0;
                while (i < repEmpleados.Count)
                {
                    dgvTicket.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno+" "+ repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    dgvReporte.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    i++;
                }
                
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                dgvEmpleados.Visible = false;
                dgvReporte.Visible = true;

            }
            else if (rBtnRecepAño.Checked)
            {
                int Registros = 0;
                new ReporteEmpleados().ReporteRecepcionistaAño(ref repEmpleados);
                int i = 0;
                while (i < repEmpleados.Count)
                {
                    dgvTicket.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    dgvReporte.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    i++;
                }

                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                dgvEmpleados.Visible = false;
                dgvReporte.Visible = true;
            }
            else if (rBtnRepaMes.Checked)
            {
                int Registros = 0;
                new ReporteEmpleados().ReporteRepartidor(ref repEmpleados);
                int i = 0;
                while (i < repEmpleados.Count)
                {
                    dgvTicket.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    dgvReporte.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    i++;
                }

                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                dgvEmpleados.Visible = false;
                dgvReporte.Visible = true;
            }
            else if (rBtnRepaAño.Checked)
            {
                int Registros = 0;
                new ReporteEmpleados().ReporteRepartidorAño(ref repEmpleados);
                int i = 0;
                while (i < repEmpleados.Count)
                {
                    dgvTicket.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    dgvReporte.Rows.Add(repEmpleados[i].IdPersona, repEmpleados[i].Nombre + " " + repEmpleados[i].APaterno + " " + repEmpleados[i].AMaterno, repEmpleados[i].Registros1);
                    i++;
                }

                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                dgvEmpleados.Visible = false;
                dgvReporte.Visible = true;
            }
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridView Ticket = dgvTicket;
            Bitmap bmp = new Bitmap(Ticket.Width, Ticket.Height, Ticket.CreateGraphics());
            Ticket.DrawToBitmap(bmp, new Rectangle(0, 0, Ticket.Width, Ticket.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Visible = true;
            dgvReporte.Visible = false;
            string Mensaje = null;
            int max1 = Recep.cantidad();
            int max2 = Rep.cantidad();
            ConsultarEmpleados.CantidadRepartidores(ref max2, ref Rep);
            ConsultarEmpleados.CantidadRecepcionistas(ref max1, ref Recep);

            ConsultarEmpleados.ObtenerRecepcionistas(ref LRecep, ref Mensaje, Recep);
            ConsultarEmpleados.ObtenerRepartidores(ref LRep, ref Mensaje, Rep);

            int i = 0;
            int a = 0;
            while (i < max1)
            {
                dgvEmpleados.Rows.Add(LRecep[i].IdPersona, LRecep[i].Nombre + " " + LRecep[i].APaterno + " " + LRecep[i].AMaterno, LRecep[i].Telefono, LRecep[i].Sexo, LRecep[i].Edad, "Recepcionista");
                i++;
            }
            while (a < max2)
            {
                dgvEmpleados.Rows.Add(LRep[a].IdPersona, LRep[a].Nombre + " " + LRep[a].APaterno + " " + LRep[a].AMaterno, LRep[a].Telefono, LRep[a].Sexo, LRep[a].Edad, "Repartidor");
                a++;
            }

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            string Mensaje = null;

            int p = 0, d = 0;

            if (rbDis.Checked)
            {
                p = 0;
                d = cbDis.SelectedIndex + 1;
            }
            if (rbPre.Checked)
            {
                d = 0;
                p = cbPre.SelectedIndex + 1;
            }
            if (rbtodo.Checked)
            {
                p = 0; d = 0;
            }

            DataTable list = null;
            dgvEmpleados.Columns.Clear();



            Repartidor.ListaProductosParametrizados(ref list, 0, d, p);

            dgvEmpleados.DataSource = list;

            foreach (DataGridViewColumn c in dgvEmpleados.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvEmpleados.CellClick += dgvEmpleados_CellClick;

            dgvEmpleados.CellClick += dgvEmpleados_CellClick;

            if (Mensaje != null)
            {
                MessageBox.Show(Mensaje);
            }
        }
    }
}
