
using System;

namespace PROMEDICAL.Business.Dto
{
    public class MedicamentosDto
    {
        public int medi_Id { get; set; }
        public string medi_Nombre { get; set; }
        public string medi_Marca { get; set; }
        public string medi_Descripcion { get; set; }
        public bool medi_EsEliminado { get; set; }
        public int medi_UsuarioRegistra { get; set; }
        public DateTime medi_FechaRegistra { get; set; }
        public int? medi_UsuarioModifica { get; set; }
        public DateTime? medi_FechaModifica { get; set; }

    }
}