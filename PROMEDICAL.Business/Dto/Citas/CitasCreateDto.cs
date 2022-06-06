using System;
using System.ComponentModel.DataAnnotations;

namespace PROMEDICAL.Business.Dto
{
    public class CitasCreateDto
    {
        [Required]
        public int paci_Id { get; set; }
        [Required]
        public int empd_Id { get; set; }
        public int tici_Id { get; set; }
        public DateTime cita_FechaCita { get; set; }
        [Required]
        public int pers_UsuarioRegistra { get; set; }
    }
}
