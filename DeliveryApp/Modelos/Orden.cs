using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Orden
    {
        string idOrden; /*{ get; set; }*/
        string estatus;
        string idDetalle;
        public Orden()
        {

        }
        public Orden(string Orden,string esta, string Det)
        {
            idOrden = Orden;
            idDetalle = Det;
            estatus = esta;
        }

        public string IdOrden { get => idOrden; set => idOrden = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
    }
}
