using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Empresas_FindDto
    {
        public int emps_Id { get; set; }
        public string emps_RTN { get; set; }
        public string emps_NombreComercial { get; set; }
        public string emps_CorreoElectronico { get; set; }
        public string emps_Telefono { get; set; }
        public string emps_Direccion { get; set; }
        public bool emps_EsActivo { get; set; }
        public int emps_UsuarioRegistra { get; set; }
        public int? emps_UsuarioModifica { get; set; }
    }
}
