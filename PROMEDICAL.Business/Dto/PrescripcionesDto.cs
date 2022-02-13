
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class PrescripcionesDto
    {
        public int pres_Id { get; set; }
        public int cita_Id { get; set; }
        public int? medi_Id { get; set; }
        public string pres_Descripcion { get; set; }
        public bool pres_EsEliminado { get; set; }
        public int pres_UsuarioRegistra { get; set; }
        public DateTime pres_FechaRegistra { get; set; }
        public int? pres_UsuarioModifica { get; set; }
        public DateTime? pres_FechaModifica { get; set; }
    }
}