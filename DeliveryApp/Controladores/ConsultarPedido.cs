using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class ConsultarPedido
    {
        public static void ObtenerPedido(ref Pedido Ped)
        {
            try
            {
                Ped = new Pedido();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
