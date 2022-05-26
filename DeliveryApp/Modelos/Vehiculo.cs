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
        string modelo;
        string tipo;
        public Vehiculo() { }

        public string IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Año { get => año; set => año = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }

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
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
        }
    }
}
