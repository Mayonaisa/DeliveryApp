using System;
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
        List <Usuario> Persona;
        List<Direccion> Direc;
        int cantidad;

        Orden iOrden;
        Detalle iDetalle;
        Solicita iSolicita;
        Usuario Ipersona;
        Direccion IDire;

        public Pedido(Orden orde, Detalle Deta, Solicita Soli) 
        {
            
        }

        public List<Usuario> Persona1 { get => Persona; set => Persona = value; }
        internal List<Orden> Orden { get => orden; set => orden = value; }
        internal List<Detalle> Detalle { get => detalle; set => detalle = value; }
        internal List<Solicita> Solicitud { get => solicitud; set => solicitud = value; }
        public Usuario Ipersona1 { get => Ipersona; set => Ipersona = value; }
        public Orden IOrden { get => iOrden; set => iOrden = value; }
        public Detalle IDetalle { get => iDetalle; set => iDetalle = value; }
        public Solicita ISolicita { get => iSolicita; set => iSolicita = value; }
        internal List<Direccion> Direc1 { get => Direc; set => Direc = value; }
        internal Direccion IDire1 { get => IDire; set => IDire = value; }

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
            Persona = new List<Usuario>();
            Direc = new List<Direccion>();

            cantidad = Cantidad();

            while (resultado.Read() && i < cantidad)
            {
                solicitud.Add(new Solicita());
                detalle.Add(new Detalle());
                orden.Add(new Orden());
                Persona.Add(new Usuario());
                Direc.Add(new Direccion());

                //solicitud[i].OrdenId1 = resultado.GetString(0).Trim();
                Orden[i].IdOrden = resultado.GetString(0).Trim();
                Detalle[i].IdOrden = resultado.GetString(0).Trim();

                Orden[i].IdDetalle = resultado.GetString(1).Trim();
                Detalle[i].IdDetalle = resultado.GetString(1).Trim();

                Orden[i].Estatus = resultado.GetString(2).Trim();
                Detalle[i].Monto = resultado.GetSqlSingle(3);

                SqlCommand Consulta2 = new SqlCommand("SELECT nombre, P.aPaterno, P.aMaterno,fechaSolicitud, D.calle1,D.calle2,D.ciudad,D.colonia,D.numCasa, D.idDireccion,C.idCliente from Solicita S, cliente C, Persona P, Orden O, Direccion D where C.idCliente=S.idCliente and O.idOrden= '" + Orden[i].IdOrden + "' and S.idOrden='" + Orden[i].IdOrden + "' and C.idCliente=P.idPersona and P.idPersona=D.idPersona", conx);
                Consulta2.Prepare();
                SqlDataReader Resultado2 = Consulta2.ExecuteReader();

                if (Resultado2.Read())
                {
                    Persona[i].Nombre = Resultado2.GetString(0).Trim();
                    Persona[i].APaterno= Resultado2.GetString(1).Trim();
                    Persona[i].AMaterno= Resultado2.GetString(2).Trim();
                    Solicitud[i].Fecha = Resultado2.GetString(3).Trim();
                    Direc[i].IdPersona = Resultado2.GetString(10).Trim();
                    Persona[i].IdPersona= Resultado2.GetString(10).Trim();

                    Direc[i].Calle1 = Resultado2.GetString(4).Trim();
                    Direc[i].Calle2 = Resultado2.GetString(5).Trim();
                    Direc[i].Ciudad = Resultado2.GetString(6).Trim();
                    Direc[i].Colonia = Resultado2.GetString(7).Trim();
                    Direc[i].NumCasa = Resultado2.GetString(8).Trim();
                    Direc[i].IdDireccion = Resultado2.GetString(9).Trim();
                }
                //SqlCommand Consulta3 = new SqlCommand("SELECT nombre, P.aPaterno, P.aMaterno,fechaSolicitud from Solicita S, cliente C, Persona P, Orden O where C.idCliente=S.idCliente and O.idOrden= '" + Orden[i].IdOrden + "' and S.idOrden='" + Orden[i].IdOrden + "' and C.idCliente=P.idPersonaand P.idPersona=D.idPersona", conx);
                //Consulta2.Prepare();
                //SqlDataReader Resultado3 = Consulta2.ExecuteReader();

                //if (Resultado3.Read())
                //{

                //}



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
        public void ConfirmarPedido(string id)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("UPDATE Orden set estatus='en camino' where idOrden= '" + id + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {

            }
            else
            {
                throw new Exception("Error");
            }

            conx.Close();
        }
        public void PedidoIndi(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT O.idOrden,O.idDetalle,O.estatus,D.monto FROM Orden O,Detalle D where O.idOrden='"+idOrden+"' and D.idOrden='"+idOrden+"' and O.estatus!='nulo'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.iDetalle = new Detalle();
                this.iOrden = new Orden();
                this.Ipersona1 = new Usuario();
                this.ISolicita = new Solicita();
                this.IDire = new Direccion();

                iSolicita.OrdenId1 = resultado.GetString(0).Trim();
                iOrden.IdOrden = resultado.GetString(0).Trim();
                iDetalle.IdOrden = resultado.GetString(0).Trim();

                iOrden.IdDetalle = resultado.GetString(1).Trim();
                iDetalle.IdDetalle = resultado.GetString(1).Trim();

                iOrden.Estatus = resultado.GetString(2).Trim();
                iDetalle.Monto = resultado.GetSqlSingle(3);
                SqlCommand Consulta2 = new SqlCommand("SELECT nombre, P.aPaterno, P.aMaterno,fechaSolicitud, D.calle1,D.calle2,D.ciudad,D.colonia,D.numCasa, D.idDireccion,C.idCliente from Solicita S, cliente C, Persona P, Orden O, Direccion D where C.idCliente=S.idCliente and O.idOrden= '" + idOrden + "' and S.idOrden='" + idOrden + "' and C.idCliente=P.idPersona and P.idPersona=D.idPersona", conx);
                Consulta2.Prepare();
                SqlDataReader Resultado2 = Consulta2.ExecuteReader();

                if (Resultado2.Read())
                {
                    Ipersona.Nombre = Resultado2.GetString(0).Trim();
                    Ipersona.APaterno = Resultado2.GetString(1).Trim();
                    Ipersona.AMaterno = Resultado2.GetString(2).Trim();
                    iSolicita.Fecha = Resultado2.GetString(3).Trim();
                    IDire.IdPersona = Resultado2.GetString(10).Trim();
                    Ipersona1.IdPersona = Resultado2.GetString(10).Trim();

                    IDire.Calle1 = Resultado2.GetString(4).Trim();
                    IDire.Calle2 = Resultado2.GetString(5).Trim();
                    IDire.Ciudad = Resultado2.GetString(6).Trim();
                    IDire.Colonia = Resultado2.GetString(7).Trim();
                    IDire.NumCasa = Resultado2.GetString(8).Trim();
                    IDire.IdDireccion = Resultado2.GetString(9).Trim();
                }

            }
            

            conx.Close();
        }

    }
}
