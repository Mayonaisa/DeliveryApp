using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Ventas
    {
        int Ptotales;
        decimal Ganancias;
        int PVendidos;
        string producto;
        int cantidad;

        public int Ptotales1 { get => Ptotales; set => Ptotales = value; }
        public decimal Ganancias1 { get => Ganancias; set => Ganancias = value; }
        public int PVendidos1 { get => PVendidos; set => PVendidos = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Ventas() { }
        public void VentasReporte()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select count(*) as pedidos_totales from Pedido,Orden where Pedido.idOrden = Orden.idOrden and estatus = 'Entregado'   ", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                this.Ptotales =int.Parse(resultado.GetValue(0).ToString());
            }
            SqlCommand consulta2 = new SqlCommand("select sum(monto) as ganancias_totales from Usuario,Solicita,Detalle,Orden where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idOrden = Orden.idOrden and estatus = 'Entregado'", conx);

            consulta2.Prepare();
            SqlDataReader resultado2 = consulta2.ExecuteReader();

            if (resultado2.Read())
            {
                this.Ganancias=decimal.Parse(resultado2.GetValue(0).ToString());
            }

            SqlCommand consulta3 = new SqlCommand("select sum (cantidad) as productos_vendidos from Usuario,Solicita,Detalle,DetalleContieneProducto,Orden where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idDetalle = DetalleContieneProducto.idDetalle and Detalle.idOrden = Orden.idOrden and estatus = 'Entregado'", conx);

            consulta3.Prepare();
            SqlDataReader resultado3 = consulta3.ExecuteReader();

            if (resultado3.Read())
            {
                this.PVendidos = int.Parse(resultado3.GetValue(0).ToString());
            }

            SqlCommand consulta4 = new SqlCommand("select top 1 nombre,sum(cantidad) as cantidad from Producto,DetalleContieneProducto,Detalle,Orden where Producto.idProducto = DetalleContieneProducto.idProducto and DetalleContieneProducto.idDetalle = Detalle.idDetalle and Detalle.idOrden = Orden.idOrden and estatus = 'Entregado' group by nombre order by cantidad desc", conx);

            consulta4.Prepare();
            SqlDataReader resultado4 = consulta4.ExecuteReader();

            if (resultado4.Read())
            {
                this.producto = resultado4.GetString(0);
                this.cantidad = int.Parse(resultado4.GetValue(1).ToString());
            }

            conx.Close();
        }
        public void VentasReportePeriodo(string inicial, string final)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select count(*) as pedidos_totales from Pedido,Orden,Solicita where Pedido.idOrden = Orden.idOrden and Orden.idOrden = Solicita.idOrden and estatus = 'Entregado' and cast(left(fechaSolicitud, LEN(fechaSolicitud) - 15) as date) between '2022-02-06' and '2022-03-06' ", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                this.Ptotales = int.Parse(resultado.GetValue(0).ToString());
            }
            SqlCommand consulta2 = new SqlCommand("select sum(monto) as ganancias_totales from Usuario,Solicita,Detalle,Orden where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idOrden = Orden.idOrden and estatus = 'Entregado' and cast(left(fechaSolicitud, LEN(fechaSolicitud) - 15) as date) between '2022-02-06' and '2022-03-06'", conx);

            consulta2.Prepare();
            SqlDataReader resultado2 = consulta2.ExecuteReader();

            if (resultado2.Read())
            {
                this.Ganancias = decimal.Parse(resultado2.GetValue(0).ToString());
            }

            SqlCommand consulta3 = new SqlCommand("select sum (cantidad) as productos_vendidos from Usuario,Solicita,Detalle,DetalleContieneProducto,Orden where Usuario.idUsuario = Solicita.idCliente and Solicita.idOrden = Detalle.idOrden and Detalle.idDetalle = DetalleContieneProducto.idDetalle and Detalle.idOrden = Orden.idOrden and estatus = 'Entregado' and cast(left(fechaSolicitud, LEN(fechaSolicitud) - 15) as date) between '2022-02-06' and '2022-03-06'", conx);

            consulta3.Prepare();
            SqlDataReader resultado3 = consulta3.ExecuteReader();

            if (resultado3.Read())
            {
                this.PVendidos = int.Parse(resultado3.GetValue(0).ToString());
            }

            SqlCommand consulta4 = new SqlCommand("select top 1 nombre,sum(cantidad) as cantidad from Producto,DetalleContieneProducto,Detalle,Orden, Solicita where Producto.idProducto = DetalleContieneProducto.idProducto and DetalleContieneProducto.idDetalle = Detalle.idDetalle and Detalle.idOrden = Orden.idOrden and Orden.idOrden = Solicita.idOrden and estatus = 'Entregado' and cast(left(fechaSolicitud, LEN(fechaSolicitud) - 15) as date) between '2022-02-06' and '2022-03-06' group by nombre order by cantidad desc", conx);

            consulta4.Prepare();
            SqlDataReader resultado4 = consulta4.ExecuteReader();

            if (resultado4.Read())
            {
                this.producto = resultado4.GetString(0);
                this.cantidad = int.Parse(resultado4.GetValue(1).ToString());
            }

            conx.Close();
        }
    }
}
