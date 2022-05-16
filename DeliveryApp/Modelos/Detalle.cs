using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    class Detalle
    {
        string idDetalle;
        decimal monto;
        string idOrden;
        public Detalle()
        {
            //SqlConnection conx = new SqlConnection(
            //   "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
            //   );


            //conx.Open();

            //SqlCommand consulta = new SqlCommand("SELECT idDetalle, monto, idOrden from Detalle", conx);

            //consulta.Prepare();
            //SqlDataReader resultado = consulta.ExecuteReader();

            //if (resultado.Read())
            //{
            //    idDetalle = resultado.GetString(0);
            //    monto = float.Parse(resultado.GetString(1));
            //    idOrden = resultado.GetString(2);
            //}
            //else
            //{
            //    throw new Exception("no se encontro el usuario");
            //}
            //conx.Close();
        }
        public Detalle(string Det, decimal dinero, string Orden)
        {
            idDetalle = Det;
            monto = dinero;
            idOrden = Orden;

        }
        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
    }
}
