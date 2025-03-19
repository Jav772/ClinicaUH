using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaUH.Capa_Datos
{
    public class Clc_Paciente
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_de_nacimiento { get; set; }
        public string Especialidad { get; set; }
    }
}