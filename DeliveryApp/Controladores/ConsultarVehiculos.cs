using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class ConsultarVehiculos
    {
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
    }
}
