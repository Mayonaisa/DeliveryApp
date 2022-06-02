using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Registra
    {
        string idRecepcionista;
        string FechaRegistro;
        string idOrden;
        public Registra() { }

        public string IdRecepcionista { get => idRecepcionista; set => idRecepcionista = value; }
        public string fechaRegistro { get => FechaRegistro; set => FechaRegistro = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
        public void NuevoRegistro(string idOrden, string idRecep, string fecha)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("insert into Registra(idRecepcionista,fechaRegistro,idOrden) values('" + idRecep + "','" + fecha + "','" + idOrden + "');", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read() && idRecep != null && idOrden !=  null && fecha != null)
            {
                this.idRecepcionista = idRecep;
                this.fechaRegistro = fecha;
                this.idOrden = idOrden;
            }
            else
            {
                conx.Close();
                throw new Exception("Error");
            }
        }
    }
}
