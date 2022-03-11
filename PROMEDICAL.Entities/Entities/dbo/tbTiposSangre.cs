using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbTiposSangre
    {
        public tbTiposSangre()
        {
            tbPacientes = new HashSet<tbPacientes>();
        }

        public int tipsan_Id { get; set; }
        public string tipsan_Descripcion { get; set; }
        public bool tipsan_EsEliminado { get; set; }
        public int tipsan_UsuarioRegistra { get; set; }
        public DateTime tipsan_FechaRegistra { get; set; }
        public int? tipsan_UsuarioModifica { get; set; }
        public DateTime? tipsan_FechaModifica { get; set; }

        public virtual ICollection<tbPacientes> tbPacientes { get; set; }
    }
}
