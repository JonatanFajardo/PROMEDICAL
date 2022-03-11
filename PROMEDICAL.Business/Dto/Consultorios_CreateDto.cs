

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Consultorios_CreateDto
    {
        public string cons_Descripcion { get; set; }
        public int? cons_UsuarioRegistra { get; set; }
    }
}
