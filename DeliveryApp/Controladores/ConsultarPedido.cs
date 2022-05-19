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
        public static void ObtenerPedido(ref Pedido Ped, ref string mensaje)
        {
            
            try
            {
                Ped = new Pedido();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void cantidadPedidos(ref int cantidad)
        {
            Pedido pedido = new Pedido();
            try
            {
                cantidad = pedido.Cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message; 
                
            }
        }
        public static void AceptarPedido(string Orden, ref Pedido PedN)
        {
            try
            {
                PedN.EstatusPedido(Orden);
                PedN=new Pedido();


            }
            catch(Exception ex)
            {

            }
        }
    }
}
