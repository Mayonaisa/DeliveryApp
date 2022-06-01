using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;

namespace DeliveryApp.Modelos
{
    public class DetalleTieneProducto
    {
        string idDetalle;
        SqlSingle cantidad;
        string idProducto;

        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public SqlSingle Cantidad { get => cantidad; set => cantidad = value; }
        public string IdProducto { get => idProducto; set => idProducto = value; }

        public DetalleTieneProducto()
        { }
        public DetalleTieneProducto(string idDet/*, int cant, string idProd*/)
        {
            idDetalle = idDet;
            //cantidad = cant;
            //idProducto = idProd;


        }

        public void nuevoProd(int cantidad, string idProducto)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand NuevaOrden = new SqlCommand("INSERT DetalleContieneProducto values ('" + IdDetalle + "'," + cantidad.ToString() + ",'" + idProducto + "')", conx);
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();


        }


        public int CantidadDetalles()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


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

        public void ListaDetallesTieneProductos(int max, ref List<DetalleTieneProducto> DetPro)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT * FROM DetalleContieneProducto", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                DetPro.Add(new DetalleTieneProducto());
                DetPro[i].IdDetalle = resultado.GetString(0);
                DetPro[i].cantidad = resultado.GetSqlSingle(1);
                DetPro[i].idProducto = resultado.GetString(2);
                i++;
            }

            conx.Close();
        }

    }
 }
