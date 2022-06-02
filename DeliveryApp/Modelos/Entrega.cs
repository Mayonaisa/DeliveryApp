using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    class Entrega
    {
        string idRepartidor;
        string idVehiculo;
        string fechaEntrega;
        string idOrden;
        public Entrega() { }

        public string IdRepartidor { get => idRepartidor; set => idRepartidor = value; }
        public string IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
        public void NuevaEntrega(string idOrd, string idRep, string idVeh, string fecha,string mensaje)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("insert into Entrega(idRepartidor,idOrden,fechaEntrega,idVehiculo) values('"+idRep+"','"+idOrd+"','"+fecha+"','"+idVeh+"');", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (idRep!=null && idOrd != null && idVeh!=null && fecha!=null)
            {
                this.idOrden= idOrd;
                this.idVehiculo = idVeh;
                this.idRepartidor = idRep;
                this.fechaEntrega = fecha;
            }
            else
            {
                conx.Close();
                throw new Exception("No se puede confirmar este pedido, faltan datos en los campos de repartidor o vehiculo");
            }
        }
        public bool ValidarEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT O.idOrden FROM Entrega E,Orden O where O.idOrden='" + idOrden + "' and E.idOrden='" + idOrden+"' and O.idOrden=E.idOrden", conx);
            string OrdenPed=null;
            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                OrdenPed = resultado.GetString(0);
                if (OrdenPed!=null || OrdenPed!=" ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                conx.Close();
                return false;
            }
        }
    }
}
