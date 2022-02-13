
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class FrecuenciasCardiacasDto
    {
        public int rica_Id { get; set; }
        public int? paci_Id { get; set; }
        public string rica_Informacion { get; set; }
        public bool? rica_EsEliminado { get; set; }
        public int? rica_UsuarioRegistra { get; set; }
        public DateTime? rica_FechaRegistra { get; set; }
        public int? rica_UsuarioModifica { get; set; }
        public DateTime? rica_FechaModifica { get; set; }

    }
}