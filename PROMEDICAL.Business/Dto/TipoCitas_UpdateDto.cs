using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class TipoCitas_UpdateDto
    {
        public int tici_Id { get; set; }
        
        public string tici_Descripcion { get; set; }
        public int? tici_UsuarioModifica { get; set; }
    }
}
