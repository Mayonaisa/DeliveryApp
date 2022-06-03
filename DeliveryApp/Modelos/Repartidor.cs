using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DeliveryApp.Modelos
{
    public class Repartidor : Persona
    {
        public Repartidor()
        {

        }
        public void IdEntrega(string idOrden)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno from Entrega, Repartidor R, Persona P WHERE '"+idOrden+"'=idOrden and R.idRepartidor=Entrega.idRepartidor and P.idPersona=R.idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                this.IdPersona = resultado.GetString(0).Trim();
                this.Nombre = resultado.GetString(1).Trim();
                this.APaterno =  resultado.GetString(2).Trim();
                this.AMaterno = resultado.GetString(3).Trim();
            }
            else
            {
                this.IdPersona = null;
                this.Nombre = "";
                this.APaterno = "";
                this.AMaterno = "";
                conx.Close();
                //throw new Exception("no se encontro el pedido");
            }
            conx.Close();
        }
        public int cantidad()
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT COUNT(*) FROM Persona P,Repartidor R where idPersona=idRepartidor", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int cant;
            if (resultado.Read())
            {
                cant = resultado.GetInt32(0);

                return cant = resultado.GetInt32(0);

            }
            else
            {
                conx.Close();
                throw new Exception("no se encontro el pedido");
            }

        }
        public void ListaRepartidores(int max, ref List<Repartidor> Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRepartidor, nombre, aPaterno, aMaterno, telefono, sexo, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Repartidor,Persona P,Direccion D where idRepartidor=P.idPersona and P.idPersona=D.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read() && i < max)
            {
                Rep.Add(new Repartidor());
                Rep[i].IdPersona = resultado.GetString(0).Trim();
                Rep[i].Nombre = resultado.GetString(1).Trim();
                Rep[i].APaterno = " " + resultado.GetString(2).Trim();
                Rep[i].AMaterno = " " + resultado.GetString(3).Trim();
                Rep[i].Telefono = resultado.GetString(4).Trim();
                Rep[i].Sexo = resultado.GetString(5).Trim();
                Rep[i].Edad = int.Parse(resultado.GetValue(6).ToString());

                //Rep[i].Dir = new Direccion();
                //Rep[i].Dir.IdDireccion = resultado.GetString(7).Trim();
                //Rep[i].Dir.Pais = resultado.GetString(8).Trim();
                //Rep[i].Dir.Estado = resultado.GetString(9).Trim();
                //Rep[i].Dir.Ciudad = resultado.GetString(10).Trim();
                //Rep[i].Dir.Calle1 = resultado.GetString(11).Trim();
                //Rep[i].Dir.Calle2 = resultado.GetString(12).Trim();
                //Rep[i].Dir.Colonia = resultado.GetString(13).Trim();
                //Rep[i].Dir.NumCasa = resultado.GetString(14).Trim();
                i++;
            }

            conx.Close();
        }
        public void RepaIndi(string  RepaId, ref Repartidor Rep)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT idRepartidor, p.nombre, aPaterno, aMaterno, telefono, sexo, Edad,idDireccion,pais,estado,ciudad,calle1,calle2,colonia,numCasa from Repartidor,Persona P,Direccion D where  P.idPersona='"+ RepaId+"' and D.idPersona='" + RepaId+"' and idRepartidor=P.idPersona", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                Rep.IdPersona = resultado.GetString(0).Trim();
                Rep.Nombre = resultado.GetString(1).Trim();
                Rep.APaterno = resultado.GetString(2).Trim();
                Rep.AMaterno =  resultado.GetString(3).Trim();
                Rep.Telefono = resultado.GetString(4).Trim();
                Rep.Sexo = resultado.GetString(5).Trim();
                Rep.Edad = int.Parse(resultado.GetValue(6).ToString());

                Rep.Dir = new Direccion();
                Rep.Dir.IdDireccion = resultado.GetString(7).Trim();
                Rep.Dir.Pais = resultado.GetString(8).Trim();
                Rep.Dir.Estado = resultado.GetString(9).Trim();
                Rep.Dir.Ciudad = resultado.GetString(10).Trim();
                Rep.Dir.Calle1 = resultado.GetString(11).Trim();
                Rep.Dir.Calle2 = resultado.GetString(12).Trim();
                Rep.Dir.Colonia = resultado.GetString(13).Trim();
                Rep.Dir.NumCasa = resultado.GetString(14).Trim();
            }

            conx.Close();
        }

        public static string actualizarCliente(string n, string ap, string am, string c, string c1, string c2, string col, string nc, string ciu)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_ActualizarEmpleado '" + n + "','" + ap + "','" + am + "','" + c + "','" + ciu + "','" + c1 + "','" + c2 + "','" + col + "','" + nc + "'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }

        public static string registrar(string nombre, string apaterno, string amaterno, string telefono, string fecha, string sexo, string edad, string pais, string estado, string ciudad, string calle1, string calle2, string colonia, string numcasa)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            conx.Open();

            SqlCommand consulta = new SqlCommand("EXEC Sp_CrearRepartidor '"+nombre+"','"+apaterno+"','"+amaterno+"','"+telefono+"','"+fecha+"','"+sexo+ "','"+edad+"','" +pais+"','"+estado+"','"+ciudad+ "','"+calle1+ "','"+calle2+ "','"+colonia+ "','"+numcasa+"'", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            if (resultado.Read())
            {
                return resultado.GetString(0);
            }
            else
            {
                conx.Close();
                return "";
            }
        }

        public static void ListaProductosParametrizados(ref DataTable Pro, int max, int d, int p)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);

            string condiciones = "";

            if (d == 1)
            {
                condiciones = "SELECT p.idPersona, p.nombre, p.aPaterno, p.aMaterno, p.telefono, p.sexo, p.edad, d.calle1, d.calle2, d.colonia, d.numCasa  FROM Recepcionista as rec, Repartidor as rep, Usuario as u, Persona as p, Direccion as d WHERE rec.idRecepcionista = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona and p.sexo = 'Masculino' or  rep.idRepartidor = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona and p.sexo = 'Masculino'";
            }
            else if (d == 2)
            {
                condiciones = "SELECT p.idPersona, p.nombre, p.aPaterno, p.aMaterno, p.telefono, p.sexo, p.edad, d.calle1, d.calle2, d.colonia, d.numCasa  FROM Recepcionista as rec, Repartidor as rep, Usuario as u, Persona as p, Direccion as d WHERE rec.idRecepcionista = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona and p.sexo = 'Femenino' or  rep.idRepartidor = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona and p.sexo = 'Femenino'";
            }
            else if (p == 1)
            {
                condiciones = "SELECT p.idPersona, p.nombre, p.aPaterno, p.aMaterno, p.telefono, p.sexo, p.edad, d.calle1, d.calle2, d.colonia, d.numCasa  FROM Recepcionista as rec, Repartidor as rep, Usuario as u, Persona as p, Direccion as d WHERE rec.idRecepcionista = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona or  rep.idRepartidor = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona ORDER BY edad ASC";
            }
            else if (p == 2)
            {
                condiciones = "SELECT p.idPersona, p.nombre, p.aPaterno, p.aMaterno, p.telefono, p.sexo, p.edad, d.calle1, d.calle2, d.colonia, d.numCasa  FROM Recepcionista as rec, Repartidor as rep, Usuario as u, Persona as p, Direccion as d WHERE rec.idRecepcionista = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona or  rep.idRepartidor = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona ORDER BY edad DESC";
            }
            else if (d == 0 && p == 0)
            {
                condiciones = "SELECT p.idPersona, p.nombre, p.aPaterno, p.aMaterno, p.telefono, p.sexo, p.edad, d.calle1, d.calle2, d.colonia, d.numCasa  FROM Recepcionista as rec, Repartidor as rep, Usuario as u, Persona as p, Direccion as d WHERE rec.idRecepcionista = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona or  rep.idRepartidor = u.idUsuario and u.idUsuario = p.idPersona and p.idPersona = d.idPersona";
            }

            //MessageBox.Show(condiciones);

            conx.Open();

            SqlCommand consulta = new SqlCommand(condiciones, conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();

            Pro = new DataTable();
            //string cadena;

            if (resultado.HasRows)
            {
                //cadena = res.GetString(0);
                //MessageBox.Show(cadena);
                Pro.Load(resultado);
                //Pro.Add(new Producto(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetSqlSingle(3)));
            }

            conx.Close();
        }

    }
}
