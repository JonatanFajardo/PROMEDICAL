using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbFrecuenciasCardiacas
    {
        public int rica_Id { get; set; }
        /// <summary>
        /// Identificador del paciente
        /// </summary>
        public int paci_Id { get; set; }
        /// <summary>
        /// Frecuencia cardíaca del paciente
        /// </summary>
        public string rica_Informacion { get; set; }
        public bool rica_EsEliminado { get; set; }
        public int rica_UsuarioRegistra { get; set; }
        public DateTime rica_FechaRegistra { get; set; }
        public int? rica_UsuarioModifica { get; set; }
        public DateTime? rica_FechaModifica { get; set; }

        public virtual tbPacientes paci { get; set; }
    }
}
