using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DeliveryApp.Modelos
{
    public class FacturaCliente
    {
        string idCliente;
        string Cnombre;
        string Apaterno;
        string Amaterno;
        string RFC;
        string Pnombre;
        int cantidad;
        decimal monto;
        string idOrden;

        decimal total;
        public FacturaCliente() { }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Cnombre1 { get => Cnombre; set => Cnombre = value; }
        public string Apaterno1 { get => Apaterno; set => Apaterno = value; }
        public string Amaterno1 { get => Amaterno; set => Amaterno = value; }
        public string RFC1 { get => RFC; set => RFC = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
        public string Pnombre1 { get => Pnombre; set => Pnombre = value; }
        public decimal Total { get => total; set => total = value; }

        public void Factura(ref List<FacturaCliente> FacturaC,string Orden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select Cli.idCliente, P.nombre,P.aPaterno,P.aMaterno,RFC, Producto.nombre, cantidad, cantidad*Producto.precio as monto, Orden.idOrden from Cliente Cli, Persona P,producto,DetalleContieneProducto,Orden, Solicita where Producto.idProducto = DetalleContieneProducto.idProducto and DetalleContieneProducto.idDetalle = Orden.idDetalle and Solicita.idOrden = Orden.idOrden and estatus = 'Entregado'  and Orden.idOrden = '"+Orden+"' and P.idPersona = Cli.idCliente and Cli.idCliente = Solicita.idCliente", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                FacturaC.Add(new FacturaCliente());
                FacturaC[i].idCliente = resultado.GetString(0).Trim();
                FacturaC[i].Cnombre=resultado.GetString(1).Trim();
                FacturaC[i].Apaterno1 =resultado.GetString(2).Trim();
                FacturaC[i].Amaterno1 = resultado.GetString(3).Trim();
                FacturaC[i].RFC = resultado.GetString(4).Trim();
                FacturaC[i].Pnombre = resultado.GetString(5).Trim();
                FacturaC[i].cantidad =int.Parse(resultado.GetValue(6).ToString());
                FacturaC[i].monto = decimal.Parse(resultado.GetValue(7).ToString());
                FacturaC[i].idOrden = resultado.GetString(8).Trim();


                i++;
            }

            conx.Close();
        }
        public void ListaFactura(ref List<FacturaCliente> FacturaC)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select Cli.idCliente, P.nombre,P.aPaterno,P.aMaterno,RFC, Producto.nombre, cantidad, cantidad*Producto.precio as monto, Orden.idOrden from Cliente Cli, Persona P,producto,DetalleContieneProducto,Orden, Solicita where Producto.idProducto = DetalleContieneProducto.idProducto and DetalleContieneProducto.idDetalle = Orden.idDetalle and Solicita.idOrden = Orden.idOrden and estatus = 'Entregado'  and Orden.idOrden = Solicita.idOrden and P.idPersona = Cli.idCliente and Cli.idCliente = Solicita.idCliente", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                FacturaC.Add(new FacturaCliente());
                FacturaC[i].idCliente = resultado.GetString(0).Trim();
                FacturaC[i].Cnombre = resultado.GetString(1).Trim();
                FacturaC[i].Apaterno1 = resultado.GetString(2).Trim();
                FacturaC[i].Amaterno1 = resultado.GetString(3).Trim();
                FacturaC[i].RFC = resultado.GetString(4).Trim();
                FacturaC[i].Pnombre = resultado.GetString(5).Trim();
                FacturaC[i].cantidad = int.Parse(resultado.GetValue(6).ToString());
                FacturaC[i].monto = decimal.Parse(resultado.GetValue(7).ToString());
                FacturaC[i].idOrden = resultado.GetString(8).Trim();


                i++;
            }

            conx.Close();
        }
        public void TotalMonto(List<FacturaCliente> Ordenes, string id)
        {
            foreach (FacturaCliente Orden in Ordenes)
            {
                if (Orden.idOrden == id)
                {
                    this.total += Orden.monto;
                }
                
            }
        }

    }
}
