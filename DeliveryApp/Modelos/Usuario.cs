using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;



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
            //Contraseña = contraseña;
            //Correo = correo;

            //SqlConnection conx = new SqlConnection(
            //	"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
            //	);

            SqlConnection conx = new SqlConnection(
				"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
				);

             
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
		//public static Usuario BuscarContraseña(string correo, string contraseña)
		//{
		//	//consulta la base de datos
		//	OdbcConnection conx = new OdbcConnection(
		//	"Driver={ODBC Driver 17 for SQL Server};" +
		//	"Server=localhost;" +
		//	"Database = DeliveryApp;" +
		//	"trusted_connection = Yes;"
		//	//"UID = myUsername;" +
		//	//"PWD = myPassword;"
		//	);
		//	conx.Open();
		//	OdbcCommand consulta = new OdbcCommand("SELECT idPersona, correo, contraseña FROM Usuario WHERE contraseña=?", conx);
		//	consulta.Parameters.Add("contraseña", OdbcType.VarChar).Value = contraseña;
		//	//consulta.Parameters.Add("contraseña", OdbcType.VarChar).Value = contraseña;
		//	consulta.Prepare();
		//	OdbcDataReader resultado = consulta.ExecuteReader();
		//	if (resultado.Read())
		//	{
		//		Usuario USR = new Usuario();
		//		USR.IdPersona = resultado.GetString(0);
		//		USR.correo = resultado.GetString(1);
		//		USR.contraseña = resultado.GetString(2);
		//		return USR;
		//	}
		//	return null;
		//}
		public bool BuscarRecepcionista(Usuario User)
        {
			//SqlConnection conx = new SqlConnection(
			//	"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
			//	);

			SqlConnection conx = new SqlConnection(
				"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
				);

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
			//SqlConnection conx = new SqlConnection(
			//	"Data Source=DESKTOP-I0PHDQ6" +
			//             ";Initial Catalog=DeliveryApp;Integrated Security=True;"
			//	);

			//ulilap   DESKTOP-I0PHDQ6
			//ulidesk  
			SqlConnection conx = new SqlConnection(
				"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
				);

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
