using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;

namespace DeliveryApp.Modelos
{
    public class RepEmpleados
    {
        string idPersona;
        string nombre;
        string aPaterno;
        string aMaterno;
        string telefono;
        string sexo;
        int Registros;

        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string APaterno { get => aPaterno; set => aPaterno = value; }
        public string AMaterno { get => aMaterno; set => aMaterno = value; }
        public int Registros1 { get => Registros; set => Registros = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public RepEmpleados() { }
        public void RecepMasRegistros(ref List<RepEmpleados> LRepEmp)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT  R.idRecepcionista,P.nombre,P.aPaterno,P.aMaterno,P.telefono,P.sexo, COUNT(*) as 'Registros' FROM Registra Re, Recepcionista R, Persona P WHERE R.idRecepcionista = Re.idRecepcionista and P.idPersona = R.idRecepcionista and cast(left(Re.fechaRegistro, LEN(Re.fechaRegistro) - 15) as date) > DATEADD(MONTH, -1, GETDATE()) group by R.idRecepcionista, p.nombre, P.aPaterno, P.aMaterno, P.telefono, P.sexo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                LRepEmp.Add(new RepEmpleados());
                LRepEmp[i].IdPersona = resultado.GetString(0).Trim();
                LRepEmp[i].Nombre = resultado.GetString(1).Trim();
                LRepEmp[i].APaterno = resultado.GetString(2).Trim();
                LRepEmp[i].AMaterno = resultado.GetString(3).Trim();
                LRepEmp[i].telefono = resultado.GetString(4).Trim();
                LRepEmp[i].sexo = resultado.GetString(5).Trim();
                LRepEmp[i].Registros1 =int.Parse(resultado.GetValue(6).ToString().Trim());

                i++;
            }

            conx.Close();
        }
        public void RecepMasRegistrosAño(ref List<RepEmpleados> LRepEmp)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT  R.idRecepcionista,P.nombre,P.aPaterno,P.aMaterno,P.telefono,P.sexo, COUNT(*) as 'Registros' FROM Registra Re, Recepcionista R, Persona P WHERE R.idRecepcionista = Re.idRecepcionista and P.idPersona = R.idRecepcionista and cast(left(Re.fechaRegistro, LEN(Re.fechaRegistro) - 15) as date) > DATEADD(YEAR, -1, GETDATE()) group by R.idRecepcionista, p.nombre, P.aPaterno, P.aMaterno, P.telefono, P.sexo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                LRepEmp.Add(new RepEmpleados());
                LRepEmp[i].IdPersona = resultado.GetString(0).Trim();
                LRepEmp[i].Nombre = resultado.GetString(1).Trim();
                LRepEmp[i].APaterno = resultado.GetString(2).Trim();
                LRepEmp[i].AMaterno = resultado.GetString(3).Trim();
                LRepEmp[i].telefono = resultado.GetString(4).Trim();
                LRepEmp[i].sexo = resultado.GetString(5).Trim();
                LRepEmp[i].Registros1 = int.Parse(resultado.GetValue(6).ToString().Trim());

                i++;
            }

            conx.Close();
        }
        public void ReparMasRegistros(ref List<RepEmpleados> LRepEmp)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno,P.telefono,P.sexo, COUNT(*) as 'Entregas' FROM Entrega E, Repartidor R, Persona P WHERE R.idRepartidor = E.idRepartidor and P.idPersona = R.idRepartidor and cast(left(E.fechaEntrega, LEN(E.fechaEntrega) - 15) as date) > DATEADD(MONTH, -1, GETDATE()) group by R.idRepartidor, p.nombre, P.aPaterno, P.aMaterno, P.telefono, P.sexo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                LRepEmp.Add(new RepEmpleados());
                LRepEmp[i].IdPersona = resultado.GetString(0).Trim();
                LRepEmp[i].Nombre = resultado.GetString(1).Trim();
                LRepEmp[i].APaterno = resultado.GetString(2).Trim();
                LRepEmp[i].AMaterno = resultado.GetString(3).Trim();
                LRepEmp[i].telefono = resultado.GetString(4).Trim();
                LRepEmp[i].sexo = resultado.GetString(5).Trim();
                LRepEmp[i].Registros1 = int.Parse(resultado.GetValue(6).ToString().Trim());

                i++;
            }

            conx.Close();
        }
        public void ReparMasRegistrosAño(ref List<RepEmpleados> LRepEmp)
        {
            SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conx"].ConnectionString);


            conx.Open();

            SqlCommand consulta = new SqlCommand("SELECT R.idRepartidor,P.nombre,P.aPaterno,P.aMaterno,P.telefono,P.sexo, COUNT(*) as 'Entregas' FROM Entrega E, Repartidor R, Persona P WHERE R.idRepartidor = E.idRepartidor and P.idPersona = R.idRepartidor and cast(left(E.fechaEntrega, LEN(E.fechaEntrega) - 15) as date) > DATEADD(YEAR, -1, GETDATE()) group by R.idRepartidor, p.nombre, P.aPaterno, P.aMaterno, P.telefono, P.sexo", conx);

            consulta.Prepare();
            SqlDataReader resultado = consulta.ExecuteReader();
            int i = 0;
            while (resultado.Read())
            {
                LRepEmp.Add(new RepEmpleados());
                LRepEmp[i].IdPersona = resultado.GetString(0).Trim();
                LRepEmp[i].Nombre = resultado.GetString(1).Trim();
                LRepEmp[i].APaterno = resultado.GetString(2).Trim();
                LRepEmp[i].AMaterno = resultado.GetString(3).Trim();
                LRepEmp[i].telefono = resultado.GetString(4).Trim();
                LRepEmp[i].sexo = resultado.GetString(5).Trim();
                LRepEmp[i].Registros1 = int.Parse(resultado.GetValue(6).ToString().Trim());

                i++;
            }

            conx.Close();
        }
    }
}
