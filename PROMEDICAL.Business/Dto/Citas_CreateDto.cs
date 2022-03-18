using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Citas_CreateDto
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
