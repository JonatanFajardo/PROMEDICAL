

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.Business.Dto
{
    public partial class Pesos_CreateDto
    {

        public int paci_Id { get; set; }
        public string peso_Descripcion { get; set; }
        public int peso_UsuarioRegistra { get; set; }
        public string jorn_Descripcion { get; set; }
        public int jorn_UsuarioRegistra { get; set; }
    }
}
