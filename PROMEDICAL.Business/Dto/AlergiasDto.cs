
using System;

namespace PROMEDICAL.Business.Dto
{
    public class AlergiasDto
    {
        public int algi_Id { get; set; }
        public string algi_Nombre { get; set; }
        public string algi_Descripcion { get; set; }
        public bool algi_EsEliminado { get; set; }
        public int algi_UsuarioRegistra { get; set; }
        public DateTime algi_FechaRegistra { get; set; }
        public int? algi_UsuarioModifica { get; set; }
        public DateTime? algi_FechaModifica { get; set; }

    }
}