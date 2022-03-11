using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbPacientes_tbAlergias
    {
        public int paal_Id { get; set; }
        public int algi_Id { get; set; }
        public int? paci_Id { get; set; }

        public virtual tbAlergias algi { get; set; }
        public virtual tbPacientes paci { get; set; }
    }
}
