using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace DeliveryApp.Modelos
{
    class Producto
    {
        private string idProducto = "";
        private string nombre = "";
        private string disponible = "";
        private SqlSingle precio = 0;

        public List<string> orden = new List<string>();

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Disponible { get => disponible; set => disponible = value; }
        public SqlSingle Precio { get => precio; set => precio = value; }
        public Producto() { }

        public Producto(string id, string n, string d, SqlSingle p)
        {
            IdProducto = id;
            Nombre = n;
            Disponible = d;
            Precio = p;
        }

        public Producto(string idnum,int n)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("select * from Producto where idProducto = 'PROD" + idnum.ToString() + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                IdProducto = resultado.GetString(0);
                IdProducto = IdProducto.Trim();
                Nombre = resultado.GetString(1);
                Nombre = Nombre.Trim();
                Nombre = Nombre.Replace('-', ' ');
                Disponible = resultado.GetString(2);
                Disponible = Disponible.Trim();
                Precio = resultado.GetSqlSingle(3);

                //prueba
                //MessageBox.Show("si hay :)");
            }
        }
        public Producto(string idnum)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("select * from Producto where idProducto = '" + idnum.ToString() + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if(resultado.Read())
            {
                IdProducto = resultado.GetString(0);
                IdProducto = IdProducto.Trim();
                Nombre = resultado.GetString(1);
                Nombre = Nombre.Trim();
                Nombre = Nombre.Replace('-', ' ');
                Disponible = resultado.GetString(2);
                Disponible = Disponible.Trim();
                Precio = resultado.GetSqlSingle(3);

                //prueba
                //MessageBox.Show("si hay :)");
            }
            else
            {
                //prueba
                //MessageBox.Show("no se encontró el producto");
            }
        }
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Producto", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int cant = 0;
            if (resultado.Read())
            {
                cant = resultado.GetInt32(0);

                return cant = resultado.GetInt32(0);

            }
            else
            {
                conx.Close();
                throw new Exception("Error");
            }

        }
        public void ListaProductos(int max, ref List<Producto> Pro)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT * FROM Producto", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Pro.Add(new Producto());
                Pro[i].idProducto = resultado.GetString(0);
                Pro[i].nombre = resultado.GetString(1);
                Pro[i].disponible = resultado.GetString(2);
                Pro[i].precio = resultado.GetSqlSingle(3);
                i++;
            }

            conx.Close();
        }

        public static void ListaProductosParametrizados(ref List<Producto> Pro, int max, int d, int p)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            string condiciones = "";

            if(d == 1)
            {
                condiciones = "SELECT * FROM Producto WHERE disponible = 'Si'";
            }
            else if (d == 2)
            {
                condiciones = "SELECT * FROM Producto WHERE disponible = 'No'";
            }
            else if (p == 1)
            {
                condiciones = "SELECT * FROM Producto ORDER BY precio ASC";
            }
            else if (p == 2)
            {
                condiciones = "SELECT * FROM Producto ORDER BY precio DESC";
            }
            else if(d== 0 && p == 0)
            {
                condiciones = "SELECT * FROM Producto";
            }

            //MessageBox.Show(condiciones);

            conx.Open();

            SqlCommand consulta = new SqlCommand(condiciones, conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            while (resultado.Read())
            {
                Pro.Add(new Producto(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetSqlSingle(3)));
            }

            conx.Close();
        }

        public void OrdenNombre ()
        {
            orden.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select REPLACE(idProducto,'PROD',''),nombre,disponible,precio from Producto order by nombre ASC", conx);

            using (var r = consulta.ExecuteReader())
            {

                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    orden.Add(s.GetString(0).Trim());
                }
            }

        }

        public void OrdenPrecio()
        {
            orden.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select REPLACE(idProducto,'PROD',''),nombre,disponible,precio from Producto order by precio ASC", conx);

            using (var r = consulta.ExecuteReader())
            {

                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    orden.Add(s.GetString(0).Trim());
                }
            }

        }

        public void OrdenDisponibilidad()
        {
            orden.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select REPLACE(idProducto,'PROD',''),nombre,disponible,precio from Producto where disponible = 'Si'", conx);

            using (var r = consulta.ExecuteReader())
            {

                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    orden.Add(s.GetString(0).Trim());
                }
            }

        }

        public void OrdenTexto(string texto)
        {
            orden.Clear();

            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("select REPLACE(idProducto,'PROD',''),nombre,disponible,precio from Producto where nombre like '%"+texto+"%' and disponible = 'Si'", conx);

            using (var r = consulta.ExecuteReader())
            {

                foreach (DbDataRecord s in r)
                {
                    //string val = s.GetString(0);
                    orden.Add(s.GetString(0).Trim());
                }
            }

        }

        public static string actualizarCliente(string id, string precio, string disponibilidad)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_ActualizarProducto '" + id + "','" + precio + "','" + disponibilidad + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }

        public static string registrar(string nombre, string dispo, string precio)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_CrearProducto '" + nombre + "','" + precio + "','" + dispo + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }
    }
}
