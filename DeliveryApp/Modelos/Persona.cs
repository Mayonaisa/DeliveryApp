using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;

namespace DeliveryApp.Modelos
{
	public class Persona
	{
		string idPersona;
		string nombre;
		string aPaterno;
		string aMaterno;
		string telefono;
		string fechaNac;
		int edad;
		string sexo;

        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string APaterno { get => aPaterno; set => aPaterno = value; }
        public string AMaterno { get => aMaterno; set => aMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public void InsertarDatos()
		{
			throw new NotImplementedException();
		}
		public Persona()
		{


		}
		public Persona(string idPersona, string nombre, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo)
		{
			IdPersona = idPersona;
			Nombre = nombre;
			APaterno=aPaterno;
			AMaterno=aMaterno;
			Telefono=telefono;
			FechaNac=fechaNac;
			Edad=edad;
			Sexo=sexo;

		}

	}
}
