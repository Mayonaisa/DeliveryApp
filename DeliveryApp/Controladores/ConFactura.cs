using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class ConFactura
    {
        public void ListaFacturas(ref List<FacturaCliente> FacCli)
        {
            new FacturaCliente().ListaFactura(ref FacCli);
        }
        public void Facturar(ref List<FacturaCliente> FacCli, string idOrden)
        {
            new FacturaCliente().Factura(ref FacCli,idOrden);
        }
    }
}
