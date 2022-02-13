
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class EspecialidadesDto
    {
        public int espc_Id { get; set; }
        public string espc_Descripcion { get; set; }
        public bool espc_EsEliminado { get; set; }
        public int espc_UsuarioRegistra { get; set; }
        public DateTime espc_FechaRegistra { get; set; }
        public int? espc_UsuarioModifica { get; set; }
        public DateTime? espc_FechaModifica { get; set; }

    }
}