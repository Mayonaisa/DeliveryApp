﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DeliveryApp.Modelos
{
    public class Vehiculo
    {
        string idVehiculo;
        string marca;
        string placa;
        string año;
        string color;
        string modelo;
        string tipo;
        public Vehiculo()
        {
            
        }

        public string IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Año { get => año; set => año = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Color { get => color; set => color = value; }

        public void IdEntrega(string id)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT V.idVehiculo,V.marca,V.placa,V.color,V.año,V.modelo,V.tipo from Entrega, Vehiculo V WHERE idOrden='" + id+"' and V.idVehiculo=Entrega.idVehiculo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.idVehiculo = resultado.GetString(0).Trim();
                this.marca = resultado.GetString(1).Trim();
                this.placa = resultado.GetString(2).Trim();
                this.color = resultado.GetString(3).Trim();
                this.año = resultado.GetString(4).Trim();
                this.modelo = resultado.GetString(5).Trim();
                this.tipo = resultado.GetString(6).Trim();
            }
            else
            {
                this.idVehiculo = "";
                this.marca = "";
                this.placa = "";
                this.color = "";
                this.año = "";
                this.modelo = "";
                this.tipo = "";
                conx.Close();
            }
            conx.Close();
        }
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Vehiculo V", conx);

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
                throw new Exception("Error");
            }

        }
        public void ListaVehiculos(int max, ref List<Vehiculo> Veh)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT V.idVehiculo,V.marca,V.modelo,V.placa,V.año,V.color,V.tipo from Vehiculo V ", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Veh.Add(new Vehiculo());
                Veh[i].idVehiculo = resultado.GetString(0).Trim();
                Veh[i].marca = resultado.GetString(1).Trim();
                Veh[i].modelo = resultado.GetString(2).Trim();
                Veh[i].placa = resultado.GetString(3).Trim();
                Veh[i].Año = resultado.GetString(4).Trim();
                Veh[i].color = resultado.GetString(5);
                Veh[i].tipo = resultado.GetString(6);
                i++;
            }

            conx.Close();
        }

        public static string actualizarCliente(string id, string tipo, string marca, string placa, string color, string modelo, string año)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_ActualizarVehiculo '" + id + "','" + tipo + "','" + marca + "','" + placa + "','" + color + "','" + año + "','" + modelo + "'", conx);

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

        public static string registrar(string marca, string placa, string color, string año, string modelo, string tipo)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_CrearVehiculo '" + marca + "','" + placa + "','" + color + "','" + año + "','" + modelo + "','"+tipo+"'", conx);

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

        public static void ListaProductosParametrizados(ref DataTable Pro, int max, int d, int p)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            string condiciones = "";

            if (d == 1)
            {
                condiciones = "select * from Vehiculo WHERE tipo = 'Moto'";
            }
            else if (d == 2)
            {
                condiciones = "select * from Vehiculo WHERE tipo = 'Carro'";
            }
            else if (p == 1)
            {
                condiciones = "select * from Vehiculo ORDER BY año ASC";
            }
            else if (p == 2)
            {
                condiciones = "select * from Vehiculo ORDER BY año DESC";
            }
            else if (d == 0 && p == 0)
            {
                condiciones = "select * from Vehiculo";
            }

            //MessageBox.Show(condiciones);

            conx.Open();

            SqlCommand consulta = new SqlCommand(condiciones, conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            Pro = new DataTable();
            //string cadena;

            if (resultado.HasRows)
            {
                //cadena = res.GetString(0);
                //MessageBox.Show(cadena);
                Pro.Load(resultado);
                //Pro.Add(new Producto(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetSqlSingle(3)));
            }

            conx.Close();
        }
    }
}
