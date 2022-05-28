using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;
using System.Configuration;

namespace DeliveryApp.Recursos
{
    public class CarritoC
    {
        public string idOrden = "";
        public string idDetalle = "";
        public string estatus = "";
        int numOrden = 0;

        private string idUsuario = "";
        string usuario = "";

        public Detalle detalle;
        public DetalleTieneProducto DetTProd;

        public List<string> nombreProd = new List<string>();
        public List<string> cantidad = new List<string>();
        public List<string> monto = new List<string>();

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public CarritoC()
        {
            
        }

        public void crear()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("SELECT COUNT (*) FROM Orden", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                numOrden = resultado.GetInt32(0);
                insert();

            }
        }

        private void insert ()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            idOrden = "ORD" + numOrden.ToString();

            SqlCommand NuevaOrden = new SqlCommand("INSERT Orden values ('ORD" + numOrden.ToString() + "','nulo','nulo')",conx); //jhbj
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();

            leer();

        }

        private void leer()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("select * from Orden where idOrden = '" + idOrden + "'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                estatus = resultado.GetString(1);
                estatus = estatus.Trim();
                idDetalle = resultado.GetString(2);
                idDetalle = idDetalle.Trim();

            }
        }

        public void update(string detalle,string estatus)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("update Orden set estatus = '"+estatus+"', idDetalle = '"+detalle+"' where idOrden = '"+idOrden+"'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            leer();
        }

        public void AgregarElemento (string nombre, string cant, string mont)
        {
            nombreProd.Add(nombre);
            cantidad.Add(cant);
            monto.Add(mont);
        }
    }
}
