using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbEmpleados
    {
        public tbEmpleados()
        {
            tbCitas = new HashSet<tbCitas>();
        }

        public int empd_Id { get; set; }
        public int pers_Id { get; set; }
        public int carg_Id { get; set; }
        public int? cons_Id { get; set; }
        public int jorn_Id { get; set; }

        public virtual tbCargos carg { get; set; }
        public virtual tbConsultorios cons { get; set; }
        public virtual tbJornadas jorn { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual ICollection<tbCitas> tbCitas { get; set; }
    }
}
