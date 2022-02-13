
using System;

namespace PROMEDICAL.Business.Dto
{
    public class PacientesDto
    {
        public int paci_Id { get; set; }
        public int? pers_Id { get; set; }
        public int? hist_Id { get; set; }
        public string tipoSangre { get; set; }
        public int? altura { get; set; }
        public int? peso { get; set; }
        public bool? paci_EsEliminado { get; set; }
        public int? paci_UsuarioRegistra { get; set; }
        public DateTime? paci_FechaRegistra { get; set; }
        public int? paci_UsuarioModifica { get; set; }
        public DateTime? paci_FechaModifica { get; set; }

    }
}