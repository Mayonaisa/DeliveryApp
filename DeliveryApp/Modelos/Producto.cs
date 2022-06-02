using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    class Producto
    {
        private string idProducto = "";
        private string nombre = "";
        private string disponible = "";
        private SqlSingle precio = 0;

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Disponible { get => disponible; set => disponible = value; }
        public SqlSingle Precio { get => precio; set => precio = value; }
        public Producto() { }
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
    }
}
