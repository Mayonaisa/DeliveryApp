using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class ConsultarProductos
    {
        public static void CantidadProductos(ref int cantidad, ref Producto Pro)
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
        public static void ObtenerProducto(ref List<Producto> Pro, ref string mensaje, Producto P)
        {
            try
            {
                int max = P.cantidad();
                P.ListaProductos(max, ref Pro);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
