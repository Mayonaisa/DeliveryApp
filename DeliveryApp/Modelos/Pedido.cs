using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeliveryApp.Modelos
{
    class Pedido
    {
        List <Orden> orden;
        List <Detalle> detalle;
        List <Solicita> solicitud;
        List <string> Persona;
        int cantidad;

        string iOrden;
        string iDetalle;
        Solicita iSolicita;

        //public Pedido() { }
        public Pedido(Orden orde, Detalle Deta, Solicita Soli) 
        {
            //orden = orde;
            //detalle = Deta;
            //solicitud=Soli;
        }

        public List<string> Persona1 { get => Persona; set => Persona = value; }
        internal List<Orden> Orden { get => orden; set => orden = value; }
        internal List<Detalle> Detalle { get => detalle; set => detalle = value; }
        internal List<Solicita> Solicitud { get => solicitud; set => solicitud = value; }


        //public string Persona1 { get => Persona; set => Persona = value; }
        //internal Orden Orden { get => orden; set => orden = value; }
        //internal Detalle Detalle { get => detalle; set => detalle = value; }
        //internal Solicita Solicitud { get => solicitud; set => solicitud = value; }

        public Pedido ()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT S.idOrden,D.idDetalle,D.monto,O.estatus,P.nombre,P.aPaterno,P.aMaterno, S.fechaSolicitud from Solicita S,Orden O, Detalle D,Persona P where S.idOrden = O.idOrden and D.idDetalle = O.idDetalle and S.idCliente = P.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;

            Solicitud = new List<Solicita>();
            detalle = new List<Detalle>();
            orden = new List<Orden>();
            Persona = new List<string>();

            cantidad = Cantidad();

            while (resultado.Read() && i<cantidad)
            {
                solicitud.Add(new Solicita());
                detalle.Add(new Detalle());
                orden.Add(new Orden());
                Persona.Add("");

                solicitud[i].OrdenId1 = resultado.GetString(0);
                Orden[i].IdOrden = resultado.GetString(0);
                Detalle[i].IdOrden = resultado.GetString(0);

                Orden[i].IdDetalle=resultado.GetString(1);
                Detalle[i].IdDetalle = resultado.GetString(1);
                Orden[i].IdDetalle = resultado.GetString(1);

                Detalle[i].Monto =decimal.Parse(resultado.GetValue(2).ToString());
                Orden[i].Estatus=resultado.GetString(3);
                Persona[i]=resultado.GetString(4);
                Persona[i] += resultado.GetString(5);
                Persona[i] += resultado.GetString(6);

                Solicitud[i].Fecha=resultado.GetString(7);

                i++;
            }
            conx.Close();
        }
        public int Cantidad()
        {
            SqlConnection conx = new SqlConnection(
                "Data Source=LAPTOP-M1F5M6N0;Initial Catalog=DeliveryApp;Integrated Security=True;"
                );


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) from Pedido", conx);

            int cantidad;
            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                cantidad = resultado.GetInt32(0);
            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }
            conx.Close();
            return cantidad;
        }

    }
}
