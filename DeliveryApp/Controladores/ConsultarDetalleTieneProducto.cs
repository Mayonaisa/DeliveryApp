using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class ConsultarDetalleTieneProducto
    {
        public static void ObtenerDetalleproducto(ref DetalleTieneProducto DerPed, ref string mensaje)
        {

            try
            {
                DerPed = new DetalleTieneProducto();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void cantidadPedidos(ref int cantidad)
        {
            DetalleTieneProducto detped = new DetalleTieneProducto();
            try
            {
                cantidad = detped.Cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
    }
}
