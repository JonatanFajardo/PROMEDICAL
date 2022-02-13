
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class EmpleadosDto
    {
        public int empd_Id { get; set; }
        public int? pers_Id { get; set; }
        public int? carg_Id { get; set; }
        public int? espc_Id { get; set; }
        public int? cons_Id { get; set; }
        public int? jorn_Id { get; set; }
        public int? emps_Id { get; set; }
        public bool? empd_EsEliminado { get; set; }
        public int? empd_UsuarioRegistra { get; set; }
        public DateTime? empd_FechaRegistra { get; set; }
        public int? empd_UsuarioModifica { get; set; }
        public DateTime? empd_FechaModifica { get; set; }

    }
}