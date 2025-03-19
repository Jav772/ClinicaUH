using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ClinicaUH.Capa_Datos;

namespace ClinicaUH.Capa_Logica
{
    public class Logica_Paciente
    {
        private static Clc_Paciente paciente = new Clc_Paciente();
        public static List<Clc_Paciente> ObtenerPaciente()
        {
            List<Clc_Paciente> pacientes = new List<Clc_Paciente>();

            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("select cedula, nombre, apellido, telefono, edad, fecha de nacimiento, especialidad from pacientes", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    paciente.Cedula = reader.GetInt32(0);
                    paciente.Nombre = reader.GetString(1);
                    paciente.Apellido = reader.GetString(2);
                    paciente.Telefono = reader.GetInt32(3);
                    paciente.Edad = reader.GetInt32(4);
                    paciente.Fecha_de_nacimiento = reader.GetDateTime(5);
                    paciente.Especialidad = reader.GetString(6);
                    pacientes.Add(paciente);
                }
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                return pacientes;
            }

            return pacientes;
        }
    }
}