using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Consultorios_UpdateDto
    {
        public int cons_Id { get; set; }
        public string cons_Descripcion { get; set; }
        public int? cons_UsuarioModifica { get; set; }
        
    }
}
