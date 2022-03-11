

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Cargos_CreateDto
    {
        public string carg_Descripcion { get; set; }
        public int carg_UsuarioRegistra { get; set; }
    }
}
