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
		Direccion dir;

		public Usuario()
		{

		}

		public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }

        public Usuario(string contraseña, string correo) 
        {
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

		public Usuario(string idPersona, string nombre, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo, string contraseña, string correo) : base(idPersona, nombre,aPaterno,aMaterno,telefono,fechaNac,edad,sexo)
		{
            Contraseña = contraseña;
            Correo = correo;

        }
        public static Usuario BuscarContraseña(string correo)
        {
			//consulta la base de datos
			SqlConnection conx = new SqlConnection(
				"Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
				);


			conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idPersona, correo, contraseña, nombre FROM Usuario, Persona WHERE correo = '" + correo + "' and Usuario.idUsuario = Persona.idPersona", conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                Usuario USR = new Usuario();
                USR.IdPersona = resultado.GetString(0);
                USR.correo = resultado.GetString(1);
                USR.contraseña = resultado.GetString(2);
				USR.Nombre = resultado.GetString(3);
                return USR;
            }
            return null;
        }
  //      public bool BuscarRecepcionista(Usuario User)
  //      {
		//	//SqlConnection conx = new SqlConnection(
		//	//	"Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
		//	//	);

		//	SqlConnection conx = new SqlConnection(
		//		"Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
		//		);

		//	conx.Open();

		//	SqlCommand consulta = new SqlCommand("SELECT idRecepcionista FROM Recepcionista WHERE idRecepcionista = '" + User.IdPersona + "'" , conx);

		//	consulta.Prepare();
		//	SqlDataReader resultado = consulta.ExecuteReader();

		//	if (resultado.Read())
		//	{
		//		conx.Close();
		//		return true;
		//	}
		//	else
		//	{
		//		conx.Close();
		//		return false;
		//	}
			
		//}
		//public bool BuscarCliente(Usuario User)
		//{
		//	//SqlConnection conx = new SqlConnection(
		//	//	"Data Source=DESKTOP-I0PHDQ6" +
		//	//             ";Initial Catalog=DeliveryApp;Integrated Security=True;"
		//	//	);
		//	SqlConnection conx = new SqlConnection(
		//		"Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
		//		);

		//	conx.Open();

		//	SqlCommand consulta = new SqlCommand("SELECT idCliente FROM Cliente WHERE idCliente = '" + User.IdPersona + "'", conx);

		//	consulta.Prepare();
		//	SqlDataReader resultado = consulta.ExecuteReader();

		//	if (resultado.Read())
		//	{
		//		conx.Close();
		//		return true;
		//	}
		//	else
		//	{
		//		conx.Close();
		//		return false;
		//	}

		//}

		public Usuario(string contraseña, string correo, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numCasa, string nombre, string idPersona, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo) : base (idPersona, nombre, aPaterno, aMaterno, telefono, fechaNac, edad, sexo)
		{
			// datos de persona
			base.Nombre = nombre;
			base.APaterno = aPaterno;
			base.AMaterno = aMaterno;
			base.Telefono = telefono;
			base.FechaNac = fechaNac;
			base.Edad = edad;
			base.Sexo = sexo;
			// datos de usuario
			Contraseña = contraseña;
			Correo = correo;
			// datos de direccion
			this.dir = new Direccion(pais, estado, ciudad, calle1, calle2, colonia, numCasa);
			// registrar
		}

		public bool RegistrarUsuario(ref string msg)
        {
			SqlConnection conx = new SqlConnection
			(
				"Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
			);

			conx.Open();

			SqlCommand consulta = new SqlCommand("EXEC Sp_CrearUsuario '"+this.Nombre+"','"+this.APaterno+"','"+this.AMaterno+"','"+this.Telefono+"','"+this.FechaNac+"','"+this.correo+"','"+this.Sexo+"','"+this.Edad+"','"+this.contraseña+"','"+this.dir.Pais+"','"+this.dir.Estado+"','"+this.dir.Ciudad+"','"+this.dir.Calle1+"','"+this.dir.Calle2+"','"+this.dir.Colonia+"','"+this.dir.NumCasa+"'",conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

			if (resultado.Read())
			{
				string correo = correo = resultado.GetString(0);
				try
				{
					this.IdPersona = resultado.GetString(1);
					msg = "Se ha registrado correctamente";
				}
				catch
                {
					msg = "El correo ya se encuentra registrado ";
				}
                conx.Close();
				return true;
			}
			else
			{
				msg = "error en los valores";
				conx.Close();
				return false;
			}
		}
	}
}
