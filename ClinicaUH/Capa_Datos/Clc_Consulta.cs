using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaUH.Capa_Datos
{
    public class Clc_Consulta
    {
        public int ConsultaID { get; set; }
        public DateTime Hora_Atencion { get; set; }
        public DateTime Fecha_Atencion { get; set; }
        public int Consultorio { get; set; }
        
    }
}