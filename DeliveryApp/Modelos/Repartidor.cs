using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Repartidor:Persona
    {
        public Repartidor()
        {
            
        }
        public void IdEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno from Entrega, Repartidor R, Persona P WHERE idOrden='"+idOrden+"' and R.idRepartidor=Entrega.idRepartidor and P.idPersona=R.idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.IdPersona = resultado.GetString(0).Trim();
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
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Persona P,Repartidor R where idPersona=idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int cant;
            if (resultado.Read())
            {
                cant= resultado.GetInt32(0);
                return cant = resultado.GetInt32(0);
                
            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
        }
        public void ListaRepartidores(int max, ref List<Repartidor> Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno from Persona P, Repartidor R where P.idPersona=R.idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i=0;
            while (resultado.Read() && i<max)
            {
                Rep.Add(new Repartidor());
                Rep[i].IdPersona = resultado.GetString(0).Trim();
                Rep[i].Nombre = resultado.GetString(1).Trim();
                Rep[i].APaterno = " " + resultado.GetString(2).Trim();
                Rep[i].AMaterno = " " + resultado.GetString(3).Trim();
                i++;
            }
            
            conx.Close();
        }

    }
}
