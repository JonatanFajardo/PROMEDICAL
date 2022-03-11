using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Citas_CreateDto
    {
        [Required]
        public int empd_Id { get; set; }
        [Required]
        public int carg_Id { get; set; }
        public int? cons_Id { get; set; }
        [Required]
        public int jorn_Id { get; set; }
        public string pers_Identidad { get; set; }
        [Required]
        public string pers_PrimerNombre { get; set; }
        public string pers_SegundoNombre { get; set; }
        [Required]
        public string pers_ApellidoPaterno { get; set; }
        public string pers_ApellidoMaterno { get; set; }
        [Required]
        public DateTime pers_FechaNacimiento { get; set; }
        public string pers_CorreoElectronico { get; set; }
        public string pers_Telefono { get; set; }
        public string pers_Calle { get; set; }
        public string pers_Ciudad { get; set; }
        public string pers_Provincia { get; set; }
        public string pers_CodigoPostal { get; set; }
        public string pers_Pais { get; set; }
        [Required]
        public string pers_Sexo { get; set; }
        [Required]
        public bool? pers_EsActivo { get; set; }
        [Required]
        public int pers_UsuarioRegistra { get; set; }
    }
}
