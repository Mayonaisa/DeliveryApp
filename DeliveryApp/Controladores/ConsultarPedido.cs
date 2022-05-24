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
        public static void PedidoEspecifico( string id,ref Pedido PedN, ref Repartidor Rep, ref Vehiculo Veh, ref string mensaje)
        {
            try
            {
                //PedN = new Pedido();
                PedN.PedidoIndi(id);
                Rep.IdEntrega(id);
                Veh.IdEntrega(id);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;                  
            }
        }
        public static void ObtenerRepartidores( ref List<Repartidor> Rep, ref string mensaje)
        {
            try
            {
                int i = 0;
                int max = 0;
                
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
