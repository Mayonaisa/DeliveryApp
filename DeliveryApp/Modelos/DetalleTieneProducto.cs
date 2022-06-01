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
        bool nuevo;

        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public SqlSingle Cantidad { get => cantidad; set => cantidad = value; }
        public string IdProducto { get => idProducto; set => idProducto = value; }
        public bool Nuevo { get => nuevo; set => nuevo = value; }

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

            SqlCommand NuevaOrden = new SqlCommand("select * from DetalleContieneProducto where idDetalle = '"+idDetalle+"' and idProducto = '"+idProducto+"'", conx);
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();
            if(resultado2.Read())
            {
                SqlSingle monto = resultado2.GetSqlSingle(1);
                string montoFinal = (monto + SqlSingle.Parse(cantidad.ToString())).ToString();

                SqlCommand NuevaOrden3 = new SqlCommand("Update DetalleContieneProducto SET cantidad = "+montoFinal+ " where idDetalle = '" + idDetalle + "' and idProducto = '" + idProducto + "'", conx);
                NuevaOrden3.Prepare();

                SqlDataReader resultado = NuevaOrden3.ExecuteReader();
                nuevo = false;
            }
            else
            {
                SqlCommand NuevaOrden2 = new SqlCommand("INSERT DetalleContieneProducto values ('" + IdDetalle + "'," + cantidad.ToString() + ",'" + idProducto + "')", conx);
                NuevaOrden2.Prepare();

                SqlDataReader resultado = NuevaOrden2.ExecuteReader();
                nuevo = true;
            }


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
