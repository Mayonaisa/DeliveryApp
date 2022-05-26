using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Producto(int idnum)
        {
            //ulilap   DESKTOP-I0PHDQ6
            //ulidesk  DESKTOP-HFCLC9N
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-HFCLC9N;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );

            conx.Open();

            SqlCommand consulta = new SqlCommand("select * from Producto where idProducto = 'PROD" + idnum.ToString() + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if(resultado.Read())
            {
                IdProducto = resultado.GetString(0);
                IdProducto = IdProducto.Trim();
                Nombre = resultado.GetString(1);
                Nombre = Nombre.Trim();
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
    }
}
