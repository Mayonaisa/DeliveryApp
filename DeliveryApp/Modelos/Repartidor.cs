using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Repartidor : Persona
    {
        public Repartidor()
        {

        }
        public void IdEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRepartidor, p.nombre, aPaterno, aMaterno, telefono, sexo, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Repartidor,Persona P,Direccion D where  P.idPersona='"+ idOrden + "' and D.idPersona='"+ idOrden + "' and idRepartidor=P.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.IdPersona = resultado.GetString(0).Trim();
                this.Nombre = resultado.GetString(1).Trim();
                this.APaterno = " " + resultado.GetString(2).Trim();
                this.AMaterno = " " + resultado.GetString(3).Trim();
            }
            else
            {
                this.IdPersona = null;
                this.Nombre = "";
                this.APaterno = "";
                this.AMaterno = "";
                conx.Close();
                //throw new Exception("no se encontro el pedido");
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
                cant = resultado.GetInt32(0);

                return cant = resultado.GetInt32(0);

            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }

        }
        public void ListaRepartidores(int max, ref List<Repartidor> Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRepartidor, nombre, aPaterno, aMaterno, telefono, sexo, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Repartidor,Persona P,Direccion D where idRepartidor=P.idPersona and P.idPersona=D.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Rep.Add(new Repartidor());
                Rep[i].IdPersona = resultado.GetString(0).Trim();
                Rep[i].Nombre = resultado.GetString(1).Trim();
                Rep[i].APaterno = " " + resultado.GetString(2).Trim();
                Rep[i].AMaterno = " " + resultado.GetString(3).Trim();
                Rep[i].Telefono = resultado.GetString(4).Trim();
                Rep[i].Sexo = resultado.GetString(5).Trim();
                Rep[i].Edad = int.Parse(resultado.GetValue(6).ToString());

                //Rep[i].Dir = new Direccion();
                //Rep[i].Dir.IdDireccion = resultado.GetString(7).Trim();
                //Rep[i].Dir.Pais = resultado.GetString(8).Trim();
                //Rep[i].Dir.Estado = resultado.GetString(9).Trim();
                //Rep[i].Dir.Ciudad = resultado.GetString(10).Trim();
                //Rep[i].Dir.Calle1 = resultado.GetString(11).Trim();
                //Rep[i].Dir.Calle2 = resultado.GetString(12).Trim();
                //Rep[i].Dir.Colonia = resultado.GetString(13).Trim();
                //Rep[i].Dir.NumCasa = resultado.GetString(14).Trim();
                i++;
            }

            conx.Close();
        }
        public void RepaIndi(string  RepaId, ref Repartidor Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRepartidor, p.nombre, aPaterno, aMaterno, telefono, sexo, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Repartidor,Persona P,Direccion D where  P.idPersona='"+ RepaId+"' and D.idPersona='" + RepaId+"' and idRepartidor=P.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                Rep.IdPersona = resultado.GetString(0).Trim();
                Rep.Nombre = resultado.GetString(1).Trim();
                Rep.APaterno = resultado.GetString(2).Trim();
                Rep.AMaterno =  resultado.GetString(3).Trim();
                Rep.Telefono = resultado.GetString(4).Trim();
                Rep.Sexo = resultado.GetString(5).Trim();
                Rep.Edad = int.Parse(resultado.GetValue(6).ToString());

                Rep.Dir = new Direccion();
                Rep.Dir.IdDireccion = resultado.GetString(7).Trim();
                Rep.Dir.Pais = resultado.GetString(8).Trim();
                Rep.Dir.Estado = resultado.GetString(9).Trim();
                Rep.Dir.Ciudad = resultado.GetString(10).Trim();
                Rep.Dir.Calle1 = resultado.GetString(11).Trim();
                Rep.Dir.Calle2 = resultado.GetString(12).Trim();
                Rep.Dir.Colonia = resultado.GetString(13).Trim();
                Rep.Dir.NumCasa = resultado.GetString(14).Trim();
            }

            conx.Close();
        }

        public static string actualizarCliente(string n, string ap, string am, string c, string c1, string c2, string col, string nc, string ciu)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_ActualizarEmpleado '" + n + "','" + ap + "','" + am + "','" + c + "','" + ciu + "','" + c1 + "','" + c2 + "','" + col + "','" + nc + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }

        public static string registrar(string nombre, string apaterno, string amaterno, string telefono, string fecha, string sexo, string edad, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numcasa)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_CrearRepartidor '"+nombre+"','"+apaterno+"','"+amaterno+"','"+telefono+"','"+fecha+"','"+sexo+ "','"+edad+"','" +pais+"','"+estado+"','"+ciudad+ "','"+calle1+ "','"+calle2+ "','"+colonia+ "','"+numcasa+"'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }

    }
}
