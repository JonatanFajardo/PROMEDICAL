
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class PersonasDto
    {
        public int pers_Id { get; set; }
        public string pers_Identidad { get; set; }
        public string pers_PrimerNombre { get; set; }
        public string pers_SegundoNombre { get; set; }
        public string pers_ApellidoPaterno { get; set; }
        public string pers_ApellidoMaterno { get; set; }
        public DateTime? pers_FechaNacimiento { get; set; }
        public string pers_CorreoElectronico { get; set; }
        public string pers_Telefono { get; set; }
        public string pers_Calle { get; set; }
        public string pers_Ciudad { get; set; }
        public string pers_Provincia { get; set; }
        public string pers_CodigoPostal { get; set; }
        public string pers_Pais { get; set; }
        public string pers_Sexo { get; set; }
        public bool? pers_EsActivo { get; set; }
        public bool? pers_EsEliminado { get; set; }
        public int? pers_UsuarioRegistra { get; set; }
        public DateTime? pers_FechaRegistra { get; set; }
        public int? pers_UsuarioModifica { get; set; }
        public DateTime? pers_FechaModifica { get; set; }

    }
}