using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

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

        public void IdEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT V.idVehiculo,V.modelo,V.marca from Entrega, Vehiculo V WHERE idOrden='" + idOrden+"' and V.idVehiculo=Entrega.idVehiculo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.idVehiculo = resultado.GetString(0).Trim();
                this.modelo = " " + resultado.GetString(1).Trim();
                this.marca = " " + resultado.GetString(2).Trim();
            }
            else
            {
                this.idVehiculo ="";
                this.modelo ="";
                this.marca ="";
                conx.Close();
                //throw new Exception("no se encontro el pedido");
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
    }
}
