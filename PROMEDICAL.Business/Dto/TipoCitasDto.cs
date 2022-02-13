
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class TipoCitasDto
    {

        public int tici_Id { get; set; }
        public string tici_Descripcion { get; set; }
        public bool? tici_EsEliminado { get; set; }
        public int? tici_UsuarioRegistra { get; set; }
        public DateTime? tici_FechaRegistra { get; set; }
        public int? tici_UsuarioModifica { get; set; }
        public DateTime? tici_FechaModifica { get; set; }

    }
}