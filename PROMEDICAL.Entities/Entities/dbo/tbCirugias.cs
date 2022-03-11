using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    /// <summary>
    /// Indica todas las cirugias que estan disponibles para un paciente.
    /// </summary>
    public partial class tbCirugias
    {
        public int ciru_Id { get; set; }
        public string ciru_Descripcion { get; set; }
        public bool ciru_EsEliminado { get; set; }
        public int ciru_UsuarioRegistra { get; set; }
        public DateTime ciru_FechaRegistra { get; set; }
        public int? ciru_UsuarioModifica { get; set; }
        public DateTime? ciru_FechaModifica { get; set; }

        public virtual tbPacientes_tbCirugias tbPacientes_tbCirugias { get; set; }
    }
}
