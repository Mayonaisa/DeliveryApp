using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                mensaje = "datos incorrectos";
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
        public void IdRecep(string contraseña, string nomu)
        {
            try
            {

            }
            catch
            {

            }
        }
        public static int ingresar(string usuario, string contraseña)
        {
            int tipoUsuario = Usuario.validarCredenciales(usuario, contraseña);
            return tipoUsuario;
        }

        public static int validarNomu(string numero)
        {
            if (numero != "")
            {
                if (Regex.IsMatch(numero, @"(^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9]){3,18}[a-zA-Z0-9]$)"))
                {
                    if (numero.Length <= 20)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}