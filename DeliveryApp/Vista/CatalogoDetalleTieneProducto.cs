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
    public partial class CatalogoDetalleTieneProducto : Form
    {
        Recepcionista Rep = new Recepcionista();
        Panel contenedor = new Panel();
        Pedido pedidos;
        DetalleTieneProducto DetPed=new DetalleTieneProducto();
        List<DetalleTieneProducto> DetPedList=new List<DetalleTieneProducto>();
        string idc;

        public CatalogoDetalleTieneProducto(Panel p, string id)
        {
            Rep = null;
            contenedor = p;
            idc = id;
            InitializeComponent();
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

        private void CatalogoDetalleTieneProducto_Load(object sender, EventArgs e)
        {
            DetalleTieneProducto a = new DetalleTieneProducto(idc);

            tbxCantidad.Texts = a.Cantidad.ToString();
            tbxIdp.Texts = a.IdProducto.ToString();
            cbxId.Texts = a.IdDetalle.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConsultaEspecificaDetalle ConPro = new ConsultaEspecificaDetalle(contenedor);
            Desplegar(ConPro);
        }
    }
}