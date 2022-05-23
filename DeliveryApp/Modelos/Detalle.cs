using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DeliveryApp.Recursos;

namespace DeliveryApp.Modelos
{
    class Detalle
    {
        string idDetalle;
        SqlSingle monto;
        string idOrden;

        CarritoC Carro;

        int numDet = 0;
        public Detalle(CarritoC c)
        {
            Carro = c;

            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand Detalle = new SqlCommand("SELECT COUNT (*) FROM Detalle", conx);


            Detalle.Prepare();
            SqlDataReader resultado = Detalle.ExecuteReader();

            if (resultado.Read())
            {
                numDet = resultado.GetInt32(0);
                insert();

            }
        }
        private void insert()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            idDetalle = "DET" + numDet.ToString();

            SqlCommand NuevoDetalle = new SqlCommand("INSERT Detalle values ('DET" + numDet.ToString() + "',0,'"+Carro.idOrden+"')", conx); //jhbj
            NuevoDetalle.Prepare();

            SqlDataReader resultado2 = NuevoDetalle.ExecuteReader();
        }
        //public Detalle(string Det, decimal dinero, string Orden)
        //{
        //    IdDetalle1 = Det;
        //    Monto1 = dinero;
        //    IdOrden1 = Orden;

        //}
        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public SqlSingle Monto { get => monto; set => monto = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
    }
}
