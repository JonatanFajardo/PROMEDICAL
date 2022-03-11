

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class TipoCitas_CreateDto
    {
        public string tici_Descripcion { get; set; }
        public int tici_UsuarioRegistra { get; set; }
    }
}
