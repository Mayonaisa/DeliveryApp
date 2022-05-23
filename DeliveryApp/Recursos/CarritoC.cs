using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;

namespace DeliveryApp.Recursos
{
    public class CarritoC
    {
        public string idOrden = "";
        public string idDetalle = "";
        public string estatus = "";
        int numOrden = 0;

        Detalle det;
        public CarritoC()
        {
            
        }

        public void crear()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
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
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            idOrden = "ORD" + numOrden.ToString();

            SqlCommand NuevaOrden = new SqlCommand("INSERT Orden values ('ORD" + numOrden.ToString() + "','nulo','nulo')",conx); //jhbj
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();

            leer();

        }

        private void leer()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
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
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand Orden = new SqlCommand("update Orden set estatus = '"+estatus+"', idDetalle = '"+detalle+"' where idOrden = '"+idOrden+"'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            leer();
        }
    }
}
