using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Controladores;
using DeliveryApp.Vista;
using DeliveryApp.Modelos;
using System.Net;
using System.Net.Mail;

namespace DeliveryApp.Vista
{
    public partial class CambiarContraseña : Form
    {
        Panel contenedor = new Panel();
        Usuario usuario = new Usuario();
        public CambiarContraseña(Panel p)
        { 
            contenedor= p;  
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            LoginUsuario Login = new LoginUsuario(contenedor);
            Desplegar(Login);
            
        }
        public void Desplegar(Form f)
        {
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }
            contenedor.Width = f.Width;
            contenedor.Height = f.Height;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            contenedor.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            sendMail("");
        }

        private void sendMail(string destino)
        {
            var fromAddress = new MailAddress("swideliveryapp@gmail.com", "Soporte Delivery App");
            var toAddress = new MailAddress("vadigi9823@akapple.com", "Mayonesa");
            const string fromPassword = "hhikgvvjeyhbbnos";
            const string subject = "Recuperación de contraseña";
            const string body = "Ya quedo jijiji";

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
        }
    }
}
