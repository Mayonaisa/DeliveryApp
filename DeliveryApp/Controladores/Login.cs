using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;
//using DeliveryApp.Delivery;

namespace DeliveryApp.Controladores
{
    class Login
    {
        //public static void insertarUsuario(string nombre, string password)
        //{
        //    Usuario user = new Usuario();
        //}
        public static void insertarUsuario(string correo, string password)
        {
            Usuario user = new Usuario();
            user.Correo = correo;
            //user.password = getMd5Hash("90segfjasdmflsj" + password + nombre);
        }
        public static bool validarUsuario(string contraseña,string correo ,ref string mensaje, ref Usuario USR)
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
                //MessageBox.Show(mensaje);
                return false;
            }
            
        }
        public static bool BuscarRecepcionista( ref string mensaje, ref Usuario USR, ref Recepcionista Recep)
        {
            Recepcionista Rep =new Recepcionista(USR);
            Recep = Rep;
            if (Rep.BuscarRecepcionista(USR))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool BuscarCliente(ref string mensaje, ref Usuario USR, ref Cliente cliente)
        {
            Cliente Cli = new Cliente(USR);
            cliente = Cli;
            if (Cli.BuscarCliente(USR))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
