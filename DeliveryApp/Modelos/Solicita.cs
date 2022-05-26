using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Solicita
    {
        string idCliente; /*{ get; set; }*/
        string fecha;
        string OrdenId;
        public Solicita()
        {

        }
        public Solicita(string id, string fech, string idOrden)
        {
            idCliente = id;
            fecha = fech;
            OrdenId = idOrden;
            
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string OrdenId1 { get => OrdenId; set => OrdenId = value; }
    }
}
