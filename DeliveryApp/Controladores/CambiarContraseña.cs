using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DeliveryApp.Controladores
{
    class CambiarContraseña
    {
        public CambiarContraseña()
        {
           
        }

        public static bool recuperarContraseña(string correo)
        {
            Usuario u = Usuario.BuscarContraseña(correo);

            if(u != null)
            {
                var fromAddress = new MailAddress("swideliveryapp@gmail.com", "Soporte Delivery App");
                var toAddress = new MailAddress(u.Correo, u.Nombre);
                const string fromPassword = "hhikgvvjeyhbbnos";
                const string subject = "Recuperación de contraseña";
                string body = u.Contraseña+"";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                return true;
            }
            else
            {
                return false;
            }
            u = null;
        }

        public static int validarCorreo(string correo)
        {
            if (correo != "")
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
                return 3;
            }
        }
    }
}