
using System;
using System.Collections.Generic;

namespace PROMEDICAL.Business.Dto
{
    public class EmpresasDto
    {
        public int emps_Id { get; set; }
        public string emps_RTN { get; set; }
        public string emps_NombreComercial { get; set; }
        public string emps_CorreoElectronico { get; set; }
        public string emps_Telefono { get; set; }
        public string emps_Calle { get; set; }
        public string emps_Ciudad { get; set; }
        public string emps_Provincia { get; set; }
        public string emps_CodigoPostal { get; set; }
        public string emps_Pais { get; set; }
        public bool? emps_EsActivo { get; set; }
        public bool? emps_EsEliminado { get; set; }
        public int? emps_UsuarioRegistra { get; set; }
        public DateTime? emps_FechaRegistra { get; set; }
        public int? emps_UsuarioModifica { get; set; }
        public DateTime? emps_FechaModifica { get; set; }

    }
}