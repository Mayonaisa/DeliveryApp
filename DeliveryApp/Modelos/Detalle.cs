using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    public class Detalle
    {
        string idDetalle;
        decimal monto;
        string idOrden;
        public Detalle()
        {

        }
        public Detalle(string Det, decimal dinero, string Orden)
        {
            idDetalle = Det;
            monto = dinero;
            idOrden = Orden;

        }
        public string IdDetalle { get => idDetalle; set => idDetalle = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string IdOrden { get => idOrden; set => idOrden = value; }
    }
}
