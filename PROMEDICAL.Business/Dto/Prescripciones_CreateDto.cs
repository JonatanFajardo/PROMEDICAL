

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Prescripciones_CreateDto
    {
        public int cita_Id { get; set; }
        public int medi_Id { get; set; }
        public string pres_Descripcion { get; set; }
        public int pres_UsuarioRegistra { get; set; }
    }
}
