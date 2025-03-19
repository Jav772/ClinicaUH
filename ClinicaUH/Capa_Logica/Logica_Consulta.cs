using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ClinicaUH.Capa_Datos;

namespace ClinicaUH.Capa_Logica
{
    public class Logica_Consulta
    {
        private static Clc_Consulta consulta = new Clc_Consulta();
        public static List<Clc_Consulta> ObtenerConsulta()
        {
            List<Clc_Consulta> consultas = new List<Clc_Consulta>();

            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("select consulta, hora atencion, fecha atencion, consultorio from consultas", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    consulta.ConsultaID = reader.GetInt32(0);
                    consulta.Hora_Atencion = reader.GetDateTime(1);
                    consulta.Fecha_Atencion = reader.GetDateTime(2);
                    consulta.Consultorio = reader.GetInt32(3);
                    consultas.Add(consulta);
                }
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                return consultas;
            }

            return consultas;
        }
    }
}
    
