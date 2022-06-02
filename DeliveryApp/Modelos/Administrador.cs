using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Administrador:Usuario
    {
        public Administrador()
        {

        }
        public Administrador(Usuario usuario)
        {
            this.IdPersona = usuario.IdPersona;
        }
        public void RecepIndi(string RecepId)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idAdministrador, p.nombre, aPaterno, aMaterno, telefono, sexo, Edad,U.nombre,U.correo,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Recepcionista,Persona P,Direccion D, Usuario U where idAdministrador='"+ RecepId + "' and idUsuario='" + RecepId + "' and P.idPersona='" + RecepId + "' and D.idPersona='" + RecepId + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            if (resultado.Read())
            {
                this.IdPersona = resultado.GetString(0).Trim();
                this.Nombre = resultado.GetString(1).Trim();
                this.APaterno = resultado.GetString(2).Trim();
                this.AMaterno = resultado.GetString(3).Trim();
                this.Telefono = resultado.GetString(4).Trim();
                this.Sexo = resultado.GetString(5).Trim();
                this.Edad = int.Parse(resultado.GetValue(6).ToString());
                this.Nomu = resultado.GetString(7).Trim();
                this.Correo = resultado.GetString(8).Trim();

                this.Dir = new Direccion();
                this.Dir.IdDireccion = resultado.GetString(9).Trim();
                this.Dir.Pais = resultado.GetString(10).Trim();
                this.Dir.Estado = resultado.GetString(11).Trim();
                this.Dir.Ciudad = resultado.GetString(12).Trim();
                this.Dir.Calle1 = resultado.GetString(13).Trim();
                this.Dir.Calle2 = resultado.GetString(14).Trim();
                this.Dir.Colonia = resultado.GetString(15).Trim();
                this.Dir.NumCasa = resultado.GetString(16).Trim();
                i++;
            }

            conx.Close();
        }
    }
}
