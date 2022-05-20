using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Modelos
{
    public class Cliente: Usuario
    {
        public Cliente()
        {

        }
        public Cliente(Usuario usuario)
        {
            this.IdPersona = usuario.IdPersona;
        }
    }
}
