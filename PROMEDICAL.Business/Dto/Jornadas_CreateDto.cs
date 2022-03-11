

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Jornadas_CreateDto
    {
        public string jorn_Descripcion { get; set; }
        public int jorn_UsuarioRegistra { get; set; }
    }
}
