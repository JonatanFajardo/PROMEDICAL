using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Prescripciones_UpdateDto
    {
        public int pres_Id { get; set; }
        public int cita_Id { get; set; }
        public int medi_Id { get; set; }
        public string pres_Descripcion { get; set; }
        public int? pres_UsuarioModifica { get; set; }
    }
}
