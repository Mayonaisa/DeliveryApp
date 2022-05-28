using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Solicita
    {
        string idCliente; /*{ get; set; }*/
        string fecha;
        string OrdenId;
        public Solicita()
        {

        }
        public Solicita(string id, string fech, string idOrden)
        {
            idCliente = id;
            fecha = fech;
            OrdenId = idOrden;

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Insert = new SqlCommand("Insert Solicita Values ('"+idCliente+"','"+fecha+"','"+OrdenId+"')", conx);


            Insert.Prepare();
            SqlDataReader resultado = Insert.ExecuteReader();

        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string OrdenId1 { get => OrdenId; set => OrdenId = value; }
    }
}
