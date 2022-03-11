using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Dto
{
    public class Cirugias_UpdateDto
    {
        public int ciru_Id { get; set; }
        public string ciru_Descripcion { get; set; }
        public int? ciru_UsuarioModifica { get; set; }
    }
}
