using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;
using System.Data.SqlClient;



namespace DeliveryApp.Modelos
{
	public class Usuario : Persona
	{
		string contraseña;
		string correo;

        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }

        public void Insertar()
		{
			//throw new NotImplementedException();
		}

        public Usuario(string contraseña, string correo) 
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

             
            conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idUsuario, correo, contraseña FROM Persona,Usuario WHERE contraseña = '"+ contraseña +"'" + " AND correo = '" + correo + "'"+"AND idPersona=idUsuario", conx);

            consulta.Prepare();
			SqlDataReader resultado=consulta.ExecuteReader();

			if (resultado.Read())
            {
                IdPersona = resultado.GetString(0);
                this.correo = resultado.GetString(1);
                this.contraseña = resultado.GetString(2);
            }
			else
            {
                throw new Exception("no se encontro el usuario");
            }
            conx.Close();
        }
        public Usuario()
		{

		}

		public Usuario(string idPersona, string nombre, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo, string contraseña, string correo) : base(idPersona, nombre,aPaterno,aMaterno,telefono,fechaNac,edad,sexo)
		{
            Contraseña = contraseña;
            Correo = correo;

        }
		public bool BuscarRecepcionista(Usuario User)
        {

			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idRecepcionista FROM Recepcionista WHERE idRecepcionista = '" + User.IdPersona + "'" , conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

			if (resultado.Read())
			{
				conx.Close();
				return true;
			}
			else
			{
				conx.Close();
				return false;
			}
			
		}
		public bool BuscarCliente(Usuario User)
		{
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idCliente FROM Cliente WHERE idCliente = '" + User.IdPersona + "'", conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

			if (resultado.Read())
			{
				conx.Close();
				return true;
			}
			else
			{
				conx.Close();
				return false;
			}

		}
	}
}
