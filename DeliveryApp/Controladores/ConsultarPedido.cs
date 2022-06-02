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
        public static void ConfirmarPedido(string Orden, ref Pedido PedN)
        {
            try
            {
                PedN.ConfirmarPedido(Orden);
               
            }
            catch (Exception ex)
            {
                
            }
        }
        public static void NuevaEntrega(string Orden, string vehiculo, string fecha, string Rep, ref Pedido PedN, ref string mensaje, ref Entrega Ent)
        {
            try
            {

                Ent.NuevaEntrega(Orden, Rep, vehiculo, fecha, mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void NuevoRegistra(string Orden, string fecha, string Rec, ref Registra Reg)
        {
            try
            {

                Reg.NuevoRegistro(Orden, Rec, fecha);
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static bool ValidarEntrega(string idOrden, Entrega Ent,ref string mensaje)
        {
            if (Ent.ValidarEntrega(idOrden))
            {
                mensaje = "Ya existe la entrega de este pedido";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ConfirmarEntregapedido(string Orden, Pedido PedN)
        {
            try
            {
                PedN.PedidoYaEntregado(Orden);
            }
            catch (Exception ex)
            {

            }
        }
        //public static bool ValidarPedidoEntregado(string idOrden, Entrega Ent, ref string mensaje)
        //{
        //    if (Ent.ValidarEntrega(idOrden))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        mensaje = "Ya existe este pedido en entrega";
        //        return false;
        //    }
        //}
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
        public static void RepartidorEspecifico(string id, ref Repartidor Rep, ref string mensaje)
        {
            try
            {
                Rep.IdEntrega(id);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
           
            }
        }
        public static void VehiculoEspecifico(string id, ref Vehiculo Veh, ref string mensaje)
        {
            try
            {
                Veh.IdEntrega(id);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
        }
        public static void ObtenerRepartidores( ref List<Repartidor> Rep, ref string mensaje, Repartidor R)
        {
            try
            {
                //R = new Repartidor();
                int max = R.cantidad();
                R.ListaRepartidores(max,ref Rep);
                
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void ObtenerVehiculos(ref List<Vehiculo> Veh, ref string mensaje, Vehiculo V)
        {
            try
            {
                //V = new Vehiculo();
                int max = V.cantidad();
                V.ListaVehiculos(max, ref Veh);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
