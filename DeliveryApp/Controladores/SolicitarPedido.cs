using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
     class SolicitarPedido
    {
        public static void ObtenerPedido(ref Pedido Ped, ref Solicita Sol)
        {
            try
            {
                Sol = new Solicita();
            }
            catch (Exception ex) { }
        }
    }
}
