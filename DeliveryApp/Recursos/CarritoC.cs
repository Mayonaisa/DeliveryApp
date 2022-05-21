using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.Recursos
{
    internal class CarritoC
    {
        int numOrden = 0;
        bool flag = false;
        public CarritoC()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand Orden = new SqlCommand("SELECT COUNT (*) FROM Orden", conx);


            Orden.Prepare();
            SqlDataReader resultado = Orden.ExecuteReader();

            if (resultado.Read())
            {
                flag = true;
                numOrden = resultado.GetInt32(0);
                //MessageBox.Show(numOrden.ToString());
                insert();
                
            }
        }

        private void insert ()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=DESKTOP-I0PHDQ6;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );
            conx.Open();

            SqlCommand NuevaOrden = new SqlCommand("INSERT Orden values ('ORD" + numOrden.ToString() + "',NULL,NULL)",conx); //jhbj
            NuevaOrden.Prepare();

            SqlDataReader resultado2 = NuevaOrden.ExecuteReader();
        }
    }
}
