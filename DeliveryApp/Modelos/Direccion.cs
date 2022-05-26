using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Modelos
{
    class Direccion
    {
        private string idPersona, idDireccion;
        private string pais, estado, ciudad, calle1, calle2, colonia, numCasa;

        public Direccion(string ip, string pa, string es, string ci, string c1, string c2, string co, string nc)
        {
            idPersona = ip;
            pais = pa;
            estado = es;
            ciudad = ci;
            calle1 = c1;
            calle2 = c2;
            colonia = co;
            numCasa = nc;
        }

        public Direccion(string pa, string es, string ci, string c1, string c2, string co, string nc)
        {
            pais = pa;
            estado = es;
            ciudad = ci;
            calle1 = c1;
            calle2 = c2;
            colonia = co;
            numCasa = nc;
        }

        public void consultarDireccion(string idPer)
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
            );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT * FROM Direccion WHERE", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {

            }
            else
            {
                throw new Exception("no se encontro el usuario");
            }
            conx.Close();
        }

        #region Propiedades
        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string IdDireccion { get => idDireccion; set => idDireccion = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Calle1 { get => calle1; set => calle1 = value; }
        public string Calle2 { get => calle2; set => calle2 = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string NumCasa { get => numCasa; set => numCasa = value; }
        #endregion
    }
}