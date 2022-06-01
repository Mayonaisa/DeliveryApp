﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Recepcionista : Usuario
    {
        public Recepcionista()
        {
            
        }
        public Recepcionista(Usuario usuario)
        {
            this.IdPersona= usuario.IdPersona;
        }
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT (*) FROM Recepcionista", conx);

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
        public void ListaRecepcionistas(int max, ref List<Recepcionista> Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRecepcionista, p.nombre, aPaterno, aMaterno, telefono, sexo, Edad,U.nombre,U.correo,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Recepcionista,Persona P,Direccion D, Usuario U where idRecepcionista=idUsuario and idRecepcionista=P.idPersona and P.idPersona=D.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Rep.Add(new Recepcionista());
                Rep[i].IdPersona = resultado.GetString(0).Trim();
                Rep[i].Nombre = resultado.GetString(1).Trim();
                Rep[i].APaterno =  resultado.GetString(2).Trim();
                Rep[i].AMaterno =  resultado.GetString(3).Trim();
                Rep[i].Telefono = resultado.GetString(4).Trim();
                Rep[i].Sexo = resultado.GetString(5).Trim();
                Rep[i].Edad =int.Parse(resultado.GetValue(6).ToString());

                Rep[i].Dir = new Direccion();
                Rep[i].Dir.IdDireccion = resultado.GetString(7).Trim();
                Rep[i].Dir.Pais = resultado.GetString(8).Trim();
                Rep[i].Dir.Estado = resultado.GetString(9).Trim();
                Rep[i].Dir.Ciudad = resultado.GetString(10).Trim();
                Rep[i].Dir.Calle1 = resultado.GetString(11).Trim();
                Rep[i].Dir.Calle2 = resultado.GetString(12).Trim();
                Rep[i].Dir.Colonia = resultado.GetString(13).Trim();
                Rep[i].Dir.NumCasa = resultado.GetString(14).Trim();
                i++;
            }

            conx.Close();
        }
    }
}
