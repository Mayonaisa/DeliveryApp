using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Modelos
{
    public class ProductoMasComprado
    {
        int cantidadProducto;
        string nombreProducto;
        public ProductoMasComprado() { }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    }
}
