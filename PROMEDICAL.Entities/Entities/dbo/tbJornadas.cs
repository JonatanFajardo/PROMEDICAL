using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbJornadas
    {
        public tbJornadas()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
        }

        public int jorn_Id { get; set; }
        public string jorn_Descripcion { get; set; }
        public bool jorn_EsEliminado { get; set; }
        public int jorn_UsuarioRegistra { get; set; }
        public DateTime jorn_FechaRegistra { get; set; }
        public int? jorn_UsuarioModifica { get; set; }
        public DateTime? jorn_FechaModifica { get; set; }

        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}
