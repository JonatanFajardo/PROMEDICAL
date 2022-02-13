
using System;

namespace PROMEDICAL.Business.Dto
{
    public class PesosDto
    {
        public int peso_Id { get; set; }
        public int? paci_Id { get; set; }
        public string peso_Descripcion { get; set; }
        public bool peso_EsEliminado { get; set; }
        public int peso_UsuarioRegistra { get; set; }
        public DateTime peso_FechaRegistra { get; set; }
        public int? peso_UsuarioModifica { get; set; }
        public DateTime? peso_FechaModifica { get; set; }
    }
}