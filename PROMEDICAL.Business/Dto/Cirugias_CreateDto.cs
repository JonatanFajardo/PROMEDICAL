

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Cirugias_CreateDto
    {
        public string ciru_Descripcion { get; set; }
        public int ciru_UsuarioRegistra { get; set; }
    }
}
