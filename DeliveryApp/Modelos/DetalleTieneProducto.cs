using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    class DetalleTieneProducto
    {
        List <string> idDetalle;
        List <int> cantidad;
        List <string> idproducto;

        public DetalleTieneProducto()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("Select idDetalle,cantidad,idProducto from DetalleContieneProducto", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            idDetalle = new List<string>();
            cantidad = new List<int>();
            idproducto = new List<string>();

            int i = 0;
            int cant = Cantidad();

            while (resultado.Read() && i<cant)
            {
                idDetalle.Add("");
                cantidad.Add(0);
                idproducto.Add("");

                idDetalle[i] = resultado.GetString(0);
                cantidad[i] =int.Parse(resultado.GetValue(1).ToString());
                idproducto[i] = resultado.GetString(2);

                i++;
            }
            conx.Close();
        }

        public List<string> IdDetalle { get => idDetalle; set => idDetalle = value; }
        public List<int> Cantidad1 { get => cantidad; set => cantidad = value; }
        public List<string> Idproducto { get => idproducto; set => idproducto = value; }

        public int Cantidad()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) from DetalleContieneProducto", conx);

            int cantidad;
            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                cantidad = resultado.GetInt32(0);
            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
            return cantidad;
        }


    }
}
