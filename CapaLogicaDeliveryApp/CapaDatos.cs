using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Generador_de_datos_DeliveryAPP
{
    public class CapaDatos
    {
        public CapaDatos() { }
        string Cnx = ConfigurationManager.ConnectionStrings["CnxOldb"].ToString();
        public void Persona(string id,string Nom, string Apat, string Amat, string Sexo, string telefono,string edad, string fechaNac)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Persona(idPersona,nombre, aPaterno, aMaterno, sexo, telefono,edad,fechaNac) VALUES (@id,@Nom, @Apat, @Amat, @Sexo,@telefono,@edad,@fechaNac)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Nom", Nom);
                    cmd.Parameters.AddWithValue("@Apat", Apat );
                    cmd.Parameters.AddWithValue("@Amat", Amat);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Usuario(string id,string correo, string contraseña)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Usuario(idPersona,correo,contraseña) VALUES (@idUsuario,@correo,@contraseña)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", id);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Direccion(string id,string calle, string calle2, string ciudad, string pais, string colonia,string estado, string numCasa, string idPersona)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Direccion(idDireccion,calle1,calle2, ciudad, pais, colonia,estado,numCasa,idPersona) VALUES (@id, @calle1,@calle2,@ciudad,@pais,@colonia,@estado,@numCasa,@FK_idPersona)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@calle1", calle);
                    cmd.Parameters.AddWithValue("@calle2", calle2);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    cmd.Parameters.AddWithValue("@pais", pais);
                    cmd.Parameters.AddWithValue("@colonia", colonia);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@numCasa", numCasa);
                    cmd.Parameters.AddWithValue("@FK_idPersona", idPersona); ///
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Administrador(string codigo)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Administrador(idPersona) VALUES (@codigo)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Repartidor(string codigo)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Repartidor(idPersona) VALUES (@codigo)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Recepcionista(string codigo)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Recepcionista(idPersona) VALUES (@codigo)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Cliente(string codigo, string RFC)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Cliente(idPersona,RFC) VALUES (@codigo,@RFC)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@RFC", RFC);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Vehiculo(string idVehiculo, string marca, string placa, string color, string tipo, string modelo, string año)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Vehiculo(idVehiculo,marca, placas, color, tipo, modelo, año) VALUES (@id,@marca, @placa, @color, @tipo, @modelo,@año)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", idVehiculo);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@año", año);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Detalle(string id, float monto, string idOrden)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Detalle(idDetalle,monto,idOrden) VALUES (@id,@monto,@idOrden)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Orden(string id, string estatus, string idDetalle)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Detalle(idOrden,estatus,idDetalle) VALUES (@id,@estatus,@idDetalle)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@estatus", estatus);
                    cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Pedido(string idOrden, string idDetalle)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Pedido(idOrden,idDetalle) VALUES (@idOrden,@idDetalle)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", idOrden);
                    cmd.Parameters.AddWithValue("@monto", idDetalle);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Producto(string id, string disponibilidad, string nombre, string precio)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Producto(idProducto,disponibilidad,nombre,precio) VALUES (@id,@disponibilidad,@nombre,@precio)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void DetalleContieneProducto(string id, int cantidad, string idProducto)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO DetalleContieneProducto(idDetalle,cantidad,idProducto) VALUES (@id,@cantidad,@idProducto)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Entrega(string idRep,string idOrden, DateTime fechaEntrega, string idVehiculo)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Entrega(idRepartidor,idOrden,fechaEntrega,idVehiculo) VALUES (@id,@idOrden,@fechaEntrega,@idVehiculo)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", idRep);
                    cmd.Parameters.AddWithValue("@cantidad", idOrden);
                    cmd.Parameters.AddWithValue("@idProducto", fechaEntrega);
                    cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Registra(string idRec, string idOrden, DateTime fechaRegistro)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Registra(idRecepcionista,idOrden,fechaRegistro) VALUES (@id,@idOrden,@fechaRegistro)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", idRec);
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);
                    cmd.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }
        public void Solicita(string idCliente, string idOrden, DateTime fechaSolicitud)
        {
            using (SqlConnection conx = new SqlConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Solicita(idCliente,idOrden,fechaSolicitud) VALUES (@id,@idOrden,@fechaSolicitud)";
                using (SqlCommand cmd = new SqlCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);
                    cmd.Parameters.AddWithValue("@fechaSolicitud", fechaSolicitud);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                conx.Close();
            }
        }

    }
}
