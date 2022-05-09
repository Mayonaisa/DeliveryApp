using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Modelos
{
    public class Recepcionista : Usuario
    {
        public Recepcionista()
        {
            
        }
        public Recepcionista(Usuario usuario)
        {
            this.IdPersona= usuario.IdPersona;
        }
    }
}
