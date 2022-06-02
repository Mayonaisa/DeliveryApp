using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class ConsultarEmpleados
    {
        public static void CantidadRecepcionistas(ref int cantidad, ref Recepcionista Rep)
        {

            try
            {
                cantidad = Rep.cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message; 

            }
        }
        public static void CantidadRepartidores(ref int cantidad, ref Repartidor Repa)
        {

            try
            {
                cantidad = Repa.cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message; 

            }
        }
        public static void ObtenerRecepcionistas(ref List<Recepcionista> Rep, ref string mensaje, Recepcionista R)
        {
            try
            {
                int max = R.cantidad();
                R.ListaRecepcionistas(max, ref Rep);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void ObtenerRepartidores(ref List<Repartidor> Repa, ref string mensaje, Repartidor R)
        {
            try
            {
                int max = R.cantidad();
                R.ListaRepartidores(max, ref Repa);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
        public static void ObtenerRepaIndi( string idOrden, ref Repartidor R)
        {
            try
            {
                Repartidor Repa=new Repartidor();
                Repa.RepaIndi(idOrden, ref R);

            }
            catch (Exception ex)
            {

            }
        }
        public static void ObtenerRecepIndi(string idOrden, ref Recepcionista R)
        {
            try
            {
                Recepcionista Repe = new Recepcionista();
                Repe.RecepIndi(idOrden,ref R);

            }
            catch (Exception ex)
            {
            }
        }
    }
}
