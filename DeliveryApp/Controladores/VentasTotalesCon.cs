using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class VentasTotalesCon
    {
        public static void ObtenerClientes(ref List<Cliente> Cli, ref string mensaje)
        {
            try
            {
                int max = new Cliente().cantidad();
                new Cliente().ListaClientes(max, ref Cli);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }

        public static void ObtenerVentasIndi(string id, VentasTotales Vt)
        {
            try
            {
                Vt.VentasGlobales(id);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static void ObtenerVentas(ref List<VentasTotales> LVtotales)
        {
            try
            {
                new VentasTotales().VentasGlobalesLista(ref LVtotales);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
    }
}
