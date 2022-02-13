
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class ConsultoriosDto
    {
        public int cons_Id { get; set; }
        public string cons_Descripcion { get; set; }
        public bool cons_EsEliminado { get; set; }
        public int cons_UsuarioRegistra { get; set; }
        public DateTime cons_FechaRegistra { get; set; }
        public int? cons_UsuarioModifica { get; set; }
        public DateTime? cons_FechaModifica { get; set; }

    }
}