
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class CirugiasDto
    {
        public int ciru_Id { get; set; }
        public string ciru_Descripcion { get; set; }
        public bool ciru_EsEliminado { get; set; }
        public int ciru_UsuarioRegistra { get; set; }
        public DateTime ciru_FechaRegistra { get; set; }
        public int? ciru_UsuarioModifica { get; set; }
        public DateTime? ciru_FechaModifica { get; set; }

    }
}