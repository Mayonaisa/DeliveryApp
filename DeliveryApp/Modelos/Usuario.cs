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
		string nomu;
		string correo;
		string contraseña;

		public Usuario()
		{

		}

		public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nomu { get => nomu; set => nomu = value; }

        public Usuario(string contraseña, string usuario) 
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

             
            conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idUsuario, nombre, contraseña FROM Usuario WHERE contraseña = '"+ contraseña +"'" + " AND nombre = '" + usuario + "'", conx);

            consulta.Prepare();
			SqlDataReader resultado=consulta.ExecuteReader();

			if (resultado.Read())
            {
                IdPersona = resultado.GetString(0);
                this.Nombre = resultado.GetString(1);
                this.contraseña = resultado.GetString(2);
            }
			else
            {
                //throw new Exception("no se encontro el usuario");
				
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
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


			conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT p.idPersona, u.correo, u.contraseña, p.nombre FROM Usuario as u, Persona as p WHERE u.correo = '" + correo + "' and u.idUsuario = p.idPersona", conx);

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

		public static int validarCredenciales (string nu,string contraseña)
		{
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

			SqlCommand consulta = new SqlCommand("EXEC Sp_ValidarUsuario '"+nu+"','"+contraseña+"'", conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

			if (resultado.Read())
			{
				try
				{
					// usuario normal
					string u = resultado.GetString(4);
					conx.Close();
					return 4;
				}
				catch
				{
                    try 
					{
						// recepcionista
						string u = resultado.GetString(3);
						conx.Close();
						return 3;
					}
					catch
                    {
						try
                        {
							// administrador
							string u = resultado.GetString(2);
							conx.Close();
							return 2;
						}
						catch
                        {
							try
                            {
								// contraseña incorrecta
								string u = resultado.GetString(1);
								conx.Close();
								return 1;
							}
							catch
                            {
								// usuario no existe
								string u = resultado.GetString(0);
								conx.Close();
								return 0;
							}
                        }
                    }
				}
			}
			else
			{
				conx.Close();
				throw new Exception("error raro");
			}
		}

        public void BuscarRecepcionista(string nu, string contraseña)
        {
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRecepcionista, nombre, APaterno,AMaterno FROM Recepcionista,Usuario,Persona where idRecepcionista=idUsuario and idUsuario=idPersona and Usuario.nombre='"+nu+"' and Usuario.contraseña='"+contraseña+"'", conx);


			consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
				this.Nombre=resultado.GetString(1);
				this.APaterno = resultado.GetString(2);
				conx.Close();
            }
            else
            {
                conx.Close();
            }

        }
		public void BuscarRecepcionistaConContraseña(string id)
		{
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

			SqlCommand consulta = new SqlCommand("SELECT idRecepcionista, nombre, APaterno FROM Recepcionista,Persona WHERE idRecepcionista = '" + id + "' and idPersona = '" + id + "'", conx);

			consulta.Prepare();
			SqlDataReader resultado = consulta.ExecuteReader();

			if (resultado.Read())
			{
				this.Nombre = resultado.GetString(1);
				this.APaterno = resultado.GetString(2);
				this.AMaterno = resultado.GetString(3);
				conx.Close();
			}
			else
			{
				conx.Close();
			}

		}
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

		public Usuario(string nu, string contraseña, string correo, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numCasa, string nombre, string idPersona, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo) : base (idPersona, nombre, aPaterno, aMaterno, telefono, fechaNac, edad, sexo)
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
			Nomu = nu;
			Contraseña = contraseña;
			Correo = correo;
			// datos de direccion
			this.Dir = new Direccion(pais, estado, ciudad, calle1, calle2, colonia, numCasa);
			// registrar
		}

		public bool RegistrarUsuario(ref string msg)
        {
			SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

			conx.Open();

			SqlCommand consulta = new SqlCommand("EXEC Sp_CrearUsuario '"+this.Nomu+"','"+this.Nombre+"','"+this.APaterno+"','"+this.AMaterno+"','"+this.Telefono+"','"+this.FechaNac+"','"+this.correo+"','"+this.Sexo+"','"+this.Edad+"','"+this.contraseña+"','"+this.Dir.Pais+"','"+this.Dir.Estado+"','"+this.Dir.Ciudad+"','"+this.Dir.Calle1+"','"+this.Dir.Calle2+"','"+this.Dir.Colonia+"','"+this.Dir.NumCasa+"'",conx);

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
					msg = "El correo o el usuario ya se encuentra registrado";
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
