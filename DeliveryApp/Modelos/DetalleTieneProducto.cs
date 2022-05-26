using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DeliveryApp.Modelos
{
    public class DetalleTieneProducto
    {
        string idDetalle;
        //SqlSingle cantidad;
        //string idProducto;

        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        //public SqlSingle Cantidad { get => cantidad; set => cantidad = value; }
        //public string IdProducto { get => idProducto; set => idProducto = value; }


        public DetalleTieneProducto(string idDet/*, int cant, string idProd*/)
        {
            idDetalle = idDet;
            //cantidad = cant;
            //idProducto = idProd;


        }

        public void nuevoProd (int cantidad, string idProducto)
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-DF9LLIC;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand NuevaOrden = new SqlCommand("INSERT DetalleContieneProducto values ('" + IdDetalle + "',"+cantidad.ToString()+",'"+idProducto+"')", conx);
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();


        }

        //List <string> idDetalle;
        //List <int> cantidad;
        //List <string> idproducto;

        //public DetalleTieneProducto()
        //{
        //    SqlConnection conx = new SqlConnection(
        //        "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
        //        );


        //    conx.Open();

        //    SqlCommand consulta = new SqlCommand("Select idDetalle,cantidad,idProducto from DetalleContieneProducto", conx);

        //    consulta.Prepare();
        //    SqlDataReader resultado = consulta.ExecuteReader();

        //    idDetalle = new List<string>();
        //    cantidad = new List<int>();
        //    idproducto = new List<string>();

        //    int i = 0;
        //    int cant = Cantidad();

        //    while (resultado.Read() && i<cant)
        //    {
        //        idDetalle.Add("");
        //        cantidad.Add(0);
        //        idproducto.Add("");

        //        idDetalle[i] = resultado.GetString(0);
        //        cantidad[i] =int.Parse(resultado.GetValue(1).ToString());
        //        idproducto[i] = resultado.GetString(2);

        //        i++;
        //    }
        //    conx.Close();
        //}

        //public List<string> IdDetalle { get => idDetalle; set => idDetalle = value; }
        //public List<int> Cantidad1 { get => cantidad; set => cantidad = value; }
        //public List<string> Idproducto { get => idproducto; set => idproducto = value; }

        //public int Cantidad()
        //{
        //    SqlConnection conx = new SqlConnection(
        //        "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
        //        );


        //    conx.Open();

        //    SqlCommand consulta = new SqlCommand("SELECT COUNT(*) from DetalleContieneProducto", conx);

        //    int cantidad;
        //    consulta.Prepare();
        //    SqlDataReader resultado = consulta.ExecuteReader();

        //    if (resultado.Read())
        //    {
        //        cantidad = resultado.GetInt32(0);
        //    }
        //    else
        //    {
        //        conx.Close();
        //        throw new Exception("no se encontro el pedido");
        //    }
        //    conx.Close();
        //    return cantidad;
        //}


    }
}
