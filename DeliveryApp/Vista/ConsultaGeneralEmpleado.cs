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
            if (e.RowIndex == -1 || e.RowIndex == dgvEmpleados.Rows.Count - 1)
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
    }
}
