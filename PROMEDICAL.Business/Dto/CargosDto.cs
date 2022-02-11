using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    internal class CargosDto
    {
        public int carg_Id { get; set; }
        public string carg_Descripcion { get; set; }
        public bool carg_EsEliminado { get; set; }
        public int carg_UsuarioRegistra { get; set; }
        public DateTime carg_FechaRegistra { get; set; }
        public int? carg_UsuarioModifica { get; set; }
        public DateTime? carg_FechaModifica { get; set; }
    }
}
