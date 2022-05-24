using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Orden
    {
        string idOrden; /*{ get; set; }*/
        string estatus;
        string idDetalle;
        public Orden()
        {
            //SqlConnection conx = new SqlConnection(
            //    "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
            //    );


            //conx.Open();

            //SqlCommand consulta = new SqlCommand("SELECT idOrden, estatus, idDetalle FROM Orden", conx);

            //consulta.Prepare();
            //SqlDataReader resultado = consulta.ExecuteReader();

            //if (resultado.Read())
            //{
            //    idOrden = resultado.GetString(0);
            //    estatus = resultado.GetString(1);
            //    idDetalle = resultado.GetString(2);
            //}
            //else
            //{
            //    throw new Exception("no se encontro el usuario");
            //}
            //conx.Close();
        }
        public Orden(string Orden,string esta, string Det)
        {
            idOrden = Orden;
            idDetalle = Det;
            estatus = esta;
        }

        public string IdOrden { get => idOrden; set => idOrden = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
    }
}
