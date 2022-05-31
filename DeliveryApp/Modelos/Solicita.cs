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

        public void borrar(string id, string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Insert = new SqlCommand("delete from Solicita where idCliente = '"+id+"' and idOrden = '"+idOrden+"'", conx);


            Insert.Prepare();
            SqlDataReader resultado = Insert.ExecuteReader();
        }

        public void leer(string id, string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("select * from Solicita where idOrden = '" + idOrden + "' and idCliente = '"+id+"'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                idCliente = resultado.GetString(0);
                idCliente = idCliente.Trim();
                fecha = resultado.GetString(1);
                fecha = fecha.Trim();
                OrdenId = resultado.GetString(2);
                OrdenId = OrdenId.Trim();

            }
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string OrdenId1 { get => OrdenId; set => OrdenId = value; }
    }
}
