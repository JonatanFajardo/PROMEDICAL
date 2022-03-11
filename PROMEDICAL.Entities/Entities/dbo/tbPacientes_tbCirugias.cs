using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbPacientes_tbCirugias
    {
        public int pagi_Id { get; set; }
        public int? paci_Id { get; set; }
        public int? ciru_Id { get; set; }

        public virtual tbPacientes paci { get; set; }
        public virtual tbCirugias pagi { get; set; }
    }
}
