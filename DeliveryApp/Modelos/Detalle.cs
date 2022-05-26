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
    public class Detalle
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
                "Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
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
                "Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            idDetalle = "DET" + numDet.ToString();
            idOrden = Carro.idOrden;
            monto = 0;

            SqlCommand NuevoDetalle = new SqlCommand("INSERT Detalle values ('DET" + numDet.ToString() + "',0,'"+idOrden+"')", conx); //jhbj
            NuevoDetalle.Prepare();

            SqlDataReader resultado2 = NuevoDetalle.ExecuteReader();
        }
        //public Detalle(string Det, decimal dinero, string Orden)
        //{
        //    IdDetalle1 = Det;
        //    Monto1 = dinero;
        //    IdOrden1 = Orden;

        //}

        public void sumarMonto (SqlSingle cantidad)
        {
            SqlSingle cant = 0;
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand NuevoDetalle = new SqlCommand("Select monto from Detalle where idDetalle = '" + idDetalle + "'", conx); //jhbj
            NuevoDetalle.Prepare();

            SqlDataReader resultado2 = NuevoDetalle.ExecuteReader();
            if (resultado2.Read())
            {
                cant = resultado2.GetSqlSingle(0);
                actualizarMonto(cantidad, cant);
            }
        }

        private void actualizarMonto (SqlSingle cantNueva, SqlSingle cantVieja)
        {
            monto += (cantNueva + cantVieja);
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand NuevoDetalle = new SqlCommand("update Detalle set monto = " + monto + " where idDetalle = '" + idDetalle + "'", conx); //jhbj
            NuevoDetalle.Prepare();

            SqlDataReader resultado2 = NuevoDetalle.ExecuteReader();
        }


        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public SqlSingle Monto { get => monto; set => monto = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
    }
}
