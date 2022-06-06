using System;

namespace PROMEDICAL.Business.Dto
{
    public class FrecuenciasCardiacasSelectDto
    {
        public int rica_Id { get; set; }
        public int rica_Alta { get; set; }
        public int rica_Baja { get; set; }
        public int rica_UsuarioRegistra { get; set; }
        public DateTime rica_FechaRegistra { get; set; }
        public int rica_UsuarioModifica { get; set; }
        public DateTime rica_FechaModifica { get; set; }
    }
}
