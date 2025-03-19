using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ClinicaUH.Capa_Datos;

namespace ClinicaUH.Capa_Logica
{
    public class Logica_Medico
    {
        private static Clc_Medico medico = new Clc_Medico();
        public static List<Clc_Medico> ObtenerMedico()
        {
            List<Clc_Medico> medicos = new List<Clc_Medico>();

            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("select consultorio, nombre medico from medico", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    medico.Consultorio = reader.GetInt32(0);
                    medico.Nombre_medico = reader.GetString(1);
                    medicos.Add(medico);
                }
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                return medicos;
            }

            return medicos;
        }
    }
}