using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbAlergias
    {
        public tbAlergias()
        {
            tbPacientes_tbAlergias = new HashSet<tbPacientes_tbAlergias>();
        }

        public int algi_Id { get; set; }
        public string algi_Nombre { get; set; }
        /// <summary>
        /// Información extra sobre la alergia.
        /// </summary>
        public string algi_Descripcion { get; set; }
        public bool algi_EsEliminado { get; set; }
        public int algi_UsuarioRegistra { get; set; }
        public DateTime algi_FechaRegistra { get; set; }
        public int? algi_UsuarioModifica { get; set; }
        public DateTime? algi_FechaModifica { get; set; }

        public virtual ICollection<tbPacientes_tbAlergias> tbPacientes_tbAlergias { get; set; }
    }
}
