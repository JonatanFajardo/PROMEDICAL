using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Pacientes_CreateDto
    {
        public int? emps_Id { get; set; }
        public int tipsan_Id { get; set; }
        public decimal peci_altura { get; set; }
        public int peci_peso { get; set; }
        [Required]
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
        public int pers_UsuarioRegistra { get; set; }
    }
}
