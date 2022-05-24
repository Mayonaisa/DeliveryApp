using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Solicita
    {
        string idCliente; /*{ get; set; }*/
        string fecha;
        string OrdenId;
        public Solicita()
        {
            //SqlConnection conx = new SqlConnection(
            //    "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
            //    );


            //conx.Open();

            //SqlCommand consulta = new SqlCommand("SELECT idCliente, fechaSolicitud, idOrden FROM Solicita", conx);

            //consulta.Prepare();
            //SqlDataReader resultado = consulta.ExecuteReader();

            //if (resultado.Read())
            //{
            //    idCliente = resultado.GetString(0);
            //    fech = resultado.GetString(1);
            //    OrdenId = resultado.GetString(2);
            //}
            //else
            //{
            //    throw new Exception("no se encontro el usuario");
            //}
            //conx.Close();
        }
        public Solicita(string id, string fech, string idOrden)
        {
            idCliente = id;
            fecha = fech;
            OrdenId = idOrden;
            
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string OrdenId1 { get => OrdenId; set => OrdenId = value; }
    }
}
