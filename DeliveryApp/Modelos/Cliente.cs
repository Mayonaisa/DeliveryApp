using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Cliente: Usuario
    {
        
        public Cliente()
        {

        }
        public Cliente(Usuario usuario)
        {
            this.IdPersona = usuario.IdPersona;
        }
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Cliente,Persona where idCliente=idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int cant=0;
            if (resultado.Read())
            {
                cant = resultado.GetInt32(0);

                return cant = resultado.GetInt32(0);

            }
            else
            {
                conx.Close();
                throw new Exception("Error");
            }

        }
        public void ListaClientes(int max, ref List<Cliente> Cli)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idCliente, nombre, aPaterno, aMaterno, telefono, sexo, RFC from Cliente,Persona where idCliente=idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Cli.Add(new Cliente());
                Cli[i].IdPersona = resultado.GetString(0).Trim();
                Cli[i].Nombre = resultado.GetString(1).Trim();
                Cli[i].APaterno = " " + resultado.GetString(2).Trim();
                Cli[i].AMaterno = " " + resultado.GetString(3).Trim();
                i++;
            }

            conx.Close();
        }
    }
}
