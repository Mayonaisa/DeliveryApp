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
        string RFC;
        
        public Cliente()
        {

        }
        public Cliente(Usuario usuario)
        {
            this.IdPersona = usuario.IdPersona;
        }

        public string RFC1 { get => RFC; set => RFC = value; }

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

            SqlCommand consulta = new SqlCommand("SELECT idCliente, nombre, aPaterno, aMaterno, telefono, sexo, RFC, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Cliente,Persona P,Direccion D where idCliente=P.idPersona and P.idPersona=D.idPersona", conx);

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
                Cli[i].Telefono = resultado.GetString(4).Trim();
                Cli[i].Sexo = resultado.GetString(5).Trim();
                Cli[i].RFC = resultado.GetString(6).Trim();
                Cli[i].Edad =int.Parse(resultado.GetValue(7).ToString());

                Cli[i].Dir = new Direccion();
                Cli[i].Dir.IdDireccion =resultado.GetString(8).Trim();
                Cli[i].Dir.Pais = resultado.GetString(9).Trim();
                Cli[i].Dir.Estado = resultado.GetString(10).Trim();
                Cli[i].Dir.Ciudad = resultado.GetString(11).Trim();
                Cli[i].Dir.Calle1 = resultado.GetString(12).Trim();
                Cli[i].Dir.Calle2 = resultado.GetString(13).Trim();
                Cli[i].Dir.Colonia = resultado.GetString(14).Trim();
                Cli[i].Dir.NumCasa = resultado.GetString(15).Trim();

                i++;
            }

            conx.Close();
        }
    }
}
