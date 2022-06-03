using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class ReporteEmpleados
    {
        public void ReporteRecepcionista(ref List<RepEmpleados> R ) 
        {
            try
            {
                
                new RepEmpleados().RecepMasRegistros(ref R);
            }
            catch (Exception ex)
            {

            }
        }
        public void ReporteRecepcionistaAño(ref List<RepEmpleados> R)
        {
            try
            {

                new RepEmpleados().RecepMasRegistrosAño(ref R);
            }
            catch (Exception ex)
            {

            }
        }
        /////////////
        public void ReporteRepartidor(ref List<RepEmpleados> R)
        {
            try
            {

                new RepEmpleados().ReparMasRegistros(ref R);
            }
            catch (Exception ex)
            {

            }
        }
        public void ReporteRepartidorAño(ref List<RepEmpleados> R)
        {
            try
            {

                new RepEmpleados().ReparMasRegistrosAño(ref R);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
