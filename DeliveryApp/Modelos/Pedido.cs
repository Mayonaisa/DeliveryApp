using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    class Pedido
    {
        Orden orden;
        Detalle detalle;
        Solicita solicitud;
        
        public Pedido() { }
        public Pedido(Orden orde, Detalle Deta, Solicita Soli) 
        {
            orden = orde;
            detalle = Deta;
            solicitud=Soli;
        }
        public void ObtenerPedidoRecepcionista()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idOrden, estatus, idDetalle FROM Orden", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                
            }
            else
            {
                throw new Exception("no se encontro el usuario");
            }
            conx.Close();
        }
    }
}
