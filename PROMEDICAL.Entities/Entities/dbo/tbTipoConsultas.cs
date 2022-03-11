using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbTipoConsultas
    {
        public int tico_Id { get; set; }
        public string tico_Descripcion { get; set; }
        public bool tico_EsEliminado { get; set; }
        public int tico_UsuarioRegistra { get; set; }
        public DateTime tico_FechaRegistra { get; set; }
        public int? tico_UsuarioModifica { get; set; }
        public DateTime? tico_FechaModifica { get; set; }
    }
}
