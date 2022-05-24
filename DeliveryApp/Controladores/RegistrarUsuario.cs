using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class RegistrarUsuario
    {
        public RegistrarUsuario()
        {

        }

        public static string registrar(string contraseña, string correo, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numCasa, string nombre, string idPersona, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo)
        {
            Usuario prueba = new Usuario(contraseña, correo, pais, estado, ciudad, calle1, calle2, colonia, numCasa, nombre, idPersona, aPaterno, aMaterno, telefono, fechaNac, edad, sexo);
            string msg = "";
            prueba.RegistrarUsuario(ref msg);
            return msg;
        }
    }
}
