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
        public static void CantidadDetallesProductos(ref int cantidad, ref Producto Pro)
        {

            try
            {
                cantidad = Pro.cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message; 

            }
        }
        public static void ObtenerDetallesProductos(ref List<DetalleTieneProducto> Pro, ref string mensaje, DetalleTieneProducto P)
        {
            try
            {
                int max = P.CantidadDetalles();
                P.ListaDetallesTieneProductos(max, ref Pro);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
