using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class VentasTotales
    {
        string idCliente;
        string nombre;
        decimal monto;
        int cantidadProducto;
        string nombreProducto;
        public VentasTotales()
        {

        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }

        public void VentasGlobales(string id)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select idCliente,nombre,SUM(monto) as monto from Usuario,Solicita,Detalle where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and idCliente = '" + id + "' group by nombre,idCliente", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                this.idCliente = resultado.GetString(0).Trim();
                this.nombre = resultado.GetString(1).Trim();
                this.monto = int.Parse(resultado.GetValue(2).ToString());

                SqlCommand consulta2 = new SqlCommand("select top 1 Usuario.nombre,cantidad,Producto.nombre from Usuario,Solicita,Detalle,DetalleContieneProducto,Producto  where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idDetalle = DetalleContieneProducto.idDetalle and DetalleContieneProducto.idProducto = Producto.idProducto and idCliente = '" + id + "' order by cantidad desc", conx);

                consulta2.Prepare();
                SqlDataReader resultado2 = consulta2.ExecuteReader();
                if (resultado2.Read())
                {
                    this.cantidadProducto = int.Parse(resultado2.GetValue(1).ToString());
                    this.nombreProducto = resultado2.GetString(2).Trim();

                }

            }

            conx.Close();
        }
        public void VentasGlobalesLista(ref List<VentasTotales> VT)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select idCliente, nombre,SUM(monto) as monto from Usuario,Solicita,Detalle where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and idCliente = Solicita.idCliente group by nombre,idCliente", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                VT.Add(new VentasTotales());
                VT[i].idCliente = resultado.GetString(0).Trim();
                VT[i].nombre = resultado.GetString(1).Trim();
                VT[i].monto = int.Parse(resultado.GetValue(2).ToString());

                SqlCommand consulta2 = new SqlCommand("select top 1 Usuario.nombre,cantidad,Producto.nombre from Usuario,Solicita,Detalle,DetalleContieneProducto,Producto  where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idDetalle = DetalleContieneProducto.idDetalle and DetalleContieneProducto.idProducto = Producto.idProducto and idCliente = '"+ VT[i].idCliente + "' order by cantidad desc", conx);

                consulta2.Prepare();
                SqlDataReader resultado2 = consulta2.ExecuteReader();

                if (resultado2.Read())
                {
                    VT[i].cantidadProducto = int.Parse(resultado2.GetValue(1).ToString().Trim());
                    VT[i].nombreProducto = resultado2.GetString(2).Trim();

                    
                }
                i++;
                conx.Close();
            }
        }
    }
}
