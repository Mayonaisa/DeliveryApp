using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class ConsultaClientes
    {
        public static void cantidadClientes(ref int cantidad, ref Cliente Cli)
        {
            
            try
            {
                cantidad =Cli.cantidad();
            }
            catch (Exception ex)
            {
                //mensaje = ex.Message; 

            }
        }
        public static void ObtenerRepartidores(ref List<Cliente> Cli, ref string mensaje, Cliente C)
        {
            try
            {
                int max = C.cantidad();
                C.ListaClientes(max, ref Cli);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }
    }
}
