﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DeliveryApp.Modelos
{
    public class Pedido
    {
        List <Orden> orden;
        List <Detalle> detalle;
        List <Solicita> solicitud;
        List <string> Persona;
        int cantidad;

        Orden iOrden;
        Detalle iDetalle;
        Solicita iSolicita;
        string Ipersona;

        public Pedido(Orden orde, Detalle Deta, Solicita Soli) 
        {
            
        }

        public List<string> Persona1 { get => Persona; set => Persona = value; }
        internal List<Orden> Orden { get => orden; set => orden = value; }
        internal List<Detalle> Detalle { get => detalle; set => detalle = value; }
        internal List<Solicita> Solicitud { get => solicitud; set => solicitud = value; }
        public string Ipersona1 { get => Ipersona; set => Ipersona = value; }
        public Orden IOrden { get => iOrden; set => iOrden = value; }
        public Detalle IDetalle { get => iDetalle; set => iDetalle = value; }
        public Solicita ISolicita { get => iSolicita; set => iSolicita = value; }

        public Pedido ()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            //SqlCommand consulta = new SqlCommand("SELECT S.idOrden,D.idDetalle,D.monto,O.estatus,P.nombre,P.aPaterno,P.aMaterno, S.fechaSolicitud from Solicita S,Orden O, Detalle D,Persona P where S.idOrden = O.idOrden and D.idDetalle = O.idDetalle and S.idCliente = P.idPersona", conx);
            SqlCommand consulta = new SqlCommand("SELECT O.idOrden,O.idDetalle,O.estatus,D.monto FROM Orden O,Detalle D where O.idOrden=D.idOrden and O.estatus!='nulo'", conx);


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

                //solicitud[i].OrdenId1 = resultado.GetString(0).Trim();
                Orden[i].IdOrden = resultado.GetString(0).Trim();
                Detalle[i].IdOrden = resultado.GetString(0).Trim();

                Orden[i].IdDetalle=resultado.GetString(1).Trim();
                Detalle[i].IdDetalle = resultado.GetString(1).Trim();

                Orden[i].Estatus=resultado.GetString(2).Trim();
                Detalle[i].Monto =resultado.GetSqlSingle(3);
                //Persona[i]=resultado.GetString(4).Trim();
                //Persona[i] += " "+resultado.GetString(5).Trim();
                //Persona[i] += " "+resultado.GetString(6).Trim();

                //Solicitud[i].Fecha=resultado.GetString(7);

                i++;
            }
            conx.Close();
        }
        public int Cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Orden O,Detalle D where O.idOrden=D.idOrden and O.estatus!='nulo'", conx);

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
                throw new Exception("no se encontro la orden");
            }
            conx.Close();
            return cantidad;
        }
        public void EstatusPedido(string id)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("UPDATE Orden set estatus='Aceptado' where idOrden= '"+id+"'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {

            }

            conx.Close();
        }
        public void PedidoIndi(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT S.idOrden,D.idDetalle,D.monto,O.estatus,P.nombre,P.aPaterno,P.aMaterno, S.fechaSolicitud from Solicita S,Orden O, Detalle D,Persona P where S.idOrden = '"+idOrden+"' and O.idOrden = '"+idOrden+"' and D.idDetalle = O.idDetalle and S.idCliente = P.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.iDetalle = new Detalle();
                this.iOrden = new Orden();
                this.Ipersona1 = null;
                this.ISolicita = new Solicita();

                iSolicita.OrdenId1 = resultado.GetString(0).Trim();
                iOrden.IdOrden = resultado.GetString(0).Trim();
                iDetalle.IdOrden = resultado.GetString(0).Trim();

                iOrden.IdDetalle = resultado.GetString(1).Trim();
                iDetalle.IdDetalle = resultado.GetString(1).Trim();
                iOrden.IdDetalle = resultado.GetString(1).Trim();

                iDetalle.Monto = resultado.GetSqlSingle(2);
                iOrden.Estatus = resultado.GetString(3).Trim();
                Ipersona = resultado.GetString(4).Trim();
                Ipersona += " " + resultado.GetString(5).Trim();
                Ipersona += " " + resultado.GetString(6).Trim();

                iSolicita.Fecha = resultado.GetString(7).Trim();

            }

            conx.Close();
        }

    }
}
