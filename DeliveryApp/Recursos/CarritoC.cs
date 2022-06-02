using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlTypes;
using CustomControls.RJControls;

namespace DeliveryApp.Recursos
{
    public class CarritoC
    {
        public string idOrden = "";
        public string idDetalle = "";
        public string estatus = "";
        int numOrden = 0;

        private string idUsuario = "";
        string usuario = "";

        public Detalle detalle;
        public DetalleTieneProducto DetTProd;

        SqlSingle m = 0;

        public List<string> nombreProd = new List<string>();
        public List<string> cantidad = new List<string>();
        public List<string> monto = new List<string>();
        public List<string> disponibilidad = new List<string>();

        public List<string> fechaH = new List<string>();
        public List<string> cantidadH = new List<string>();
        public List<string> montoH = new List<string>();
        public List<string> idOrdenH = new List<string>();

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public CarritoC()
        {


            
        }

        public void crear()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("SELECT COUNT (*) FROM Orden", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                numOrden = resultado.GetInt32(0);
                insert();

            }
        }

        private void insert ()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            idOrden = "ORD" + numOrden.ToString();

            SqlCommand NuevaOrden = new SqlCommand("INSERT Orden values ('ORD" + numOrden.ToString() + "','nulo','nulo')",conx); //jhbj
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();

            leer();

        }

        public void leer()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("select * from Orden where idOrden = '" + idOrden + "'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                estatus = resultado.GetString(1);
                estatus = estatus.Trim();
                idDetalle = resultado.GetString(2);
                idDetalle = idDetalle.Trim();

            }
        }

        public void update(string detalle,string estatus)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("update Orden set estatus = '"+estatus+"', idDetalle = '"+detalle+"' where idOrden = '"+idOrden+"'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            leer();
        }

        public void AgregarElemento (string nombre, string cant, string mont)
        {
            nombreProd.Add(nombre);
            cantidad.Add(cant);
            monto.Add(mont);
        }

        public void Verificar (string idClien)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand Orden = new SqlCommand("select idOrden from Solicita where idCliente = '"+idClien+"' intersect select idOrden from Orden where estatus !='entregado'", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();
            if(resultado.Read())
            {
                string idOrd = resultado.GetString(0);
                idOrd = idOrd.Trim();

                idOrden = idOrd;

                leer();
                detalle = new Detalle();
                detalle.refrescar(idOrden);

                refrescarCarrito();
            }
            else
            {
                //MessageBox.Show("no hay carnal");
                crear();
            }
        }

        public void refrescarCarrito ()
        {
            nombreProd.Clear();
            monto.Clear();
            cantidad.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand registros = new SqlCommand("select nombre,cantidad,precio,Producto.idProducto from Producto, DetalleContieneProducto where Producto.idProducto = DetalleContieneProducto.idProducto and idDetalle = '" + idDetalle + "'", conx);
            

            using (var r = registros.ExecuteReader())
            {
                
                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    nombreProd.Add(s.GetString(0).Trim());
                    cantidad.Add(s.GetValue(1).ToString());
                    string mon = (int.Parse(s.GetValue(2).ToString()) * int.Parse(s.GetValue(1).ToString())).ToString();
                    monto.Add(mon);
                    m += SqlSingle.Parse(mon);
                }
                detalle.Monto = m;
            }
        }

        public void eliminarProd (string nombre)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand registros = new SqlCommand("select Producto.idProducto from Producto, DetalleContieneProducto where Producto.idProducto = DetalleContieneProducto.idProducto and idDetalle = '"+idDetalle+"' and nombre = '"+nombre+"'", conx);

            SqlDataReader resultado = registros.ExecuteReader();
            if(resultado.Read())
            {
                string idProd = resultado.GetString(0);
                SqlCommand borrar = new SqlCommand("Delete from DetalleContieneProducto where idDetalle = '" + idDetalle + "' and idProducto = '"+idProd+"'", conx);

                SqlDataReader borr = borrar.ExecuteReader();

                refrescarCarrito();
            }
        }

        public void Historial()
        {
            fechaH.Clear();
            cantidadH.Clear();
            montoH.Clear();
            idOrdenH.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand registros = new SqlCommand("select fechaSolicitud, SUM(cantidad) as cantidad, monto, Orden.idOrden from Solicita, Orden,DetalleContieneProducto, Detalle where Solicita.idOrden = Orden.idOrden and Orden.idDetalle = DetalleContieneProducto.idDetalle and Orden.idDetalle = Detalle.idDetalle and estatus = 'entregado' and idCliente = '" + idUsuario+ "' group by fechaSolicitud,monto,Orden.idOrden", conx);


            using (var r = registros.ExecuteReader())
            {

                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    fechaH.Add(s.GetString(0).Trim());
                    cantidadH.Add(s.GetValue(1).ToString());
                    montoH.Add(s.GetValue(2).ToString());
                    idOrdenH.Add(s.GetString(3).Trim());
                }
            }
        }

        public string nombreCliente = "";
        public string direccion = "";
        public string nombreRepartidor = "";
        public string nombreRec = "";
        public void consultaHistorial (string id)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand consulta = new SqlCommand("select nombre, aPaterno, aMaterno, calle1, calle2, numCasa from Persona, Direccion, Solicita where Persona.idPersona = Direccion.idPersona and Solicita.idCliente = Persona.idPersona and idOrden = '"+id+"'", conx);

            SqlDataReader con = consulta.ExecuteReader();

            if(con.Read())
            {
                nombreCliente = con.GetString(0).Trim() + " " + con.GetString(1).Trim() + " " + con.GetString(2).Trim();
                direccion = con.GetString(3).Trim() + ", " + con.GetString(4).Trim() + " #" + con.GetString(5).Trim();

                consulta = new SqlCommand("select nombre, aPaterno, aMaterno from Persona, Entrega where Persona.idPersona = Entrega.idRepartidor and idOrden = '"+id+"'", conx);

                SqlDataReader con2 = consulta.ExecuteReader();
                if(con2.Read())
                {
                    nombreRepartidor = con2.GetString(0).Trim() + " " + con2.GetString(1).Trim() + " " + con2.GetString(2).Trim();
                }

                consulta = new SqlCommand("select nombre, aPaterno, aMaterno from Persona, Registra where Persona.idPersona = Registra.idRecepcionista and idOrden = '" + id + "'", conx);

                SqlDataReader con3 = consulta.ExecuteReader();

                if(con3.Read())
                {
                    nombreRec = con3.GetString(0).Trim() + " " + con3.GetString(1).Trim() + " " + con3.GetString(2).Trim();
                }
            }
        }

        public void consultaEsp (string id,bool flag)
        {
            nombreProd.Clear();
            monto.Clear();
            cantidad.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);
            conx.Open();

            SqlCommand registros = new SqlCommand("select nombre,cantidad,precio,Detalle.idDetalle from Producto, DetalleContieneProducto,Detalle where Producto.idProducto = DetalleContieneProducto.idProducto and DetalleContieneProducto.idDetalle = Detalle.idDetalle and idOrden = '"+id+"'", conx);

            if (flag == true)
            {

                using (var r = registros.ExecuteReader())
                {

                    foreach (DbDataRecord s in r)
                    {
                        //string val = s.GetString(0);
                        nombreProd.Add(s.GetString(0).Trim());
                        cantidad.Add(s.GetValue(1).ToString());
                        string mon = (int.Parse(s.GetValue(2).ToString()) * int.Parse(s.GetValue(1).ToString())).ToString();
                        monto.Add(mon);
                        m += SqlSingle.Parse(mon);
                    }
                }
            }
            else
            {
                using (var r = registros.ExecuteReader())
                {

                    foreach (DbDataRecord s in r)
                    {
                        //string val = s.GetString(0);
                        nombreProd.Add(s.GetString(3).Trim());
                    }
                }

                SqlCommand deta = new SqlCommand("select monto from Detalle where idDetalle = '" + nombreProd[0] + "'", conx);

                SqlDataReader con = deta.ExecuteReader();
                if(con.Read())
                {
                    monto.Add(con.GetValue(0).ToString());
                }
            }
        }

        public void menu()
        {

        }
    }
}
