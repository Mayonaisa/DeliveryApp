using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    class Pedido
    {
        Orden Ord;
        Detalle Det;
        Solicita solicitud;
        public Pedido() { }
        public Pedido(Orden orde, Detalle Deta, Solicita Soli) 
        {
            Ord = orde;
            Det = Deta;
            solicitud=Soli;
        }
    }
}
