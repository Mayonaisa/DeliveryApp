using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class Login
    {
        public Login()
        {
        
        }

        public static bool validarUsuario(string contraseña,string correo, ref string mensaje, ref Usuario USR)
        {
            try
            {
                USR = new Usuario(contraseña,correo);
            }
            catch (Exception ex)
            {
                //mensaje = "nombre de usuario o contraseña incorrectos";
                mensaje = ex.Message;
                return false;
            }

            if (USR.Contraseña.Replace(" ","") == contraseña && USR.Correo.Replace(" ", "") == correo) // contraseña correcta
            {
                return true;
            }
            else
            {
                USR = null;
                mensaje = "correo de usuario o contraseña incorrectos";
                return false;
            }
        }

        public static int ingresar(string usuario, string contraseña)
        {
            int tipoUsuario = Usuario.validarCredenciales(usuario, contraseña);
            return tipoUsuario;
        }
    }
}