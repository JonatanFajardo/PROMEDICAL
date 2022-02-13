
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class CitasDto
    {
        public int cita_Id { get; set; }
        public int? empd_Id { get; set; }
        public int? paci_Id { get; set; }
        public int tici_Id { get; set; }
        public int tico_Id { get; set; }
        public DateTime? cita_FechaCita { get; set; }
        public bool? cita_EsEliminado { get; set; }
        public int? cita_UsuarioRegistra { get; set; }
        public DateTime? cita_FechaRegistra { get; set; }
        public int? cita_UsuarioModifica { get; set; }
        public DateTime? cita_FechaModifica { get; set; }
    }
}