using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Repartidor:Persona
    {
        public Repartidor()
        {
            
        }
        public void IdEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno from Entrega, Repartidor R, Persona P WHERE idOrden='"+idOrden+"' and R.idRepartidor=Entrega.idRepartidor and P.idPersona=R.idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.IdPersona = resultado.GetString(0);
                this.Nombre =resultado.GetString(1).Trim();
                this.APaterno =" "+ resultado.GetString(2).Trim();
                this.AMaterno =" "+ resultado.GetString(3).Trim();
            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
        }
        public void cantidad(int cantidad)
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Persona P,Recepartidor R where idPersona=idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                cantidad= resultado.GetInt32(0);
            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
        }

    }
}
