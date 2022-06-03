using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    class RegistrarUsuario
    {
        public RegistrarUsuario()
        {

        }

        public static string registrar(string nu, string contraseña, string correo, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numCasa, string nombre, string idPersona, string aPaterno, string aMaterno, string telefono, string fechaNac, int edad, string sexo, string rfc)
        {
            Usuario prueba = new Usuario(nu, contraseña, correo, pais, estado, ciudad, calle1, calle2, colonia, numCasa, nombre, idPersona, aPaterno, aMaterno, telefono, fechaNac, edad, sexo);
            string msg = "";
            prueba.RegistrarUsuario(ref msg, rfc);
            return msg;
        }

        public static int validarNombre(string nombre)
        {
            if (nombre != "")
            {
                if (Regex.IsMatch(nombre, @"^[\p{L} \.'\-]+$"))
                {
                    if (nombre.Length <= 25)
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

        public static int validarApellido(string apellido)
        {
            if (apellido != "")
            {
                if (Regex.IsMatch(apellido, @"^[\p{L} \.'\-]+$"))
                {
                    if (apellido.Length <= 20)
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

        public static int validarTelefono(string telefono)
        {
            if(telefono != "")
            {
                if (Regex.IsMatch(telefono, @"\d*"))
                {
                    if (telefono.Length >= 10 && telefono.Length <= 10)
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

        public static int validarRFC(string RFC)
        {
            if (RFC != "")
            {
                if (Regex.IsMatch(RFC, @"^([A-Z\s]{4})\d{6}([A-Z\w]{3})$"))
                {
                    if (RFC.Length < 15)
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

        public static int validarCalle(string direccion)
        {
            if (direccion != "")
            {
                if (Regex.IsMatch(direccion, @"[A-Za-z0-9'\.\-\s\,]*"))
                {
                    if (direccion.Length <= 25)
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

        public static int validarCasa(string numero)
        {
            if (numero != "")
            {
                if (Regex.IsMatch(numero, @"^[0-9]*$"))
                {
                    if (numero.Length <= 3)
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

        public static int validarCorreo(string correo, string confirmar)
        {
            if (correo != "")
            {
                if(correo == confirmar)
                {
                    if (Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        if (correo.Length <= 40)
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
                    return 4;
                }
            }
            else
            {
                return 3;
            }
        }

        public static int validarNomu(string numero)
        {
            if (numero != "" && numero.Length >= 3)
            {
                if (Regex.IsMatch(numero, @"(^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9])[a-zA-Z0-9]$){0,20}"))
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

        public static int validarContraseña(string correo, string confirmar)
        {
            if (correo != "")
            {
                if (correo == confirmar)
                {
                    
                        if (correo.Length <= 40)
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
                    return 4;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}
