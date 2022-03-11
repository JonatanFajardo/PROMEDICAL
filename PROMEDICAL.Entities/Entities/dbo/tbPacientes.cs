using System;
using System.Collections.Generic;

namespace PROMEDICAL.Entities.Entities
{
    public partial class tbPacientes
    {
        public tbPacientes()
        {
            tbCitas = new HashSet<tbCitas>();
            tbFrecuenciasCardiacas = new HashSet<tbFrecuenciasCardiacas>();
            tbPacientes_tbAlergias = new HashSet<tbPacientes_tbAlergias>();
            tbPacientes_tbCirugias = new HashSet<tbPacientes_tbCirugias>();
        }

        /// <summary>
        /// Identificador único de la tabla pacientes.
        /// </summary>
        public int paci_Id { get; set; }
        /// <summary>
        /// Este es el ID de la persona que hace referencia al primary key de la tabla tbPersonas.
        /// </summary>
        public int pers_Id { get; set; }
        public int? emps_Id { get; set; }
        /// <summary>
        /// Este es el ID del tipo de sangre que hace referencia al primary key de la tabla tbtbTiposSangre.
        /// </summary>
        public int tipsan_Id { get; set; }
        /// <summary>
        /// Información de la altura en metros del pasiente.
        /// </summary>
        public decimal peci_altura { get; set; }
        /// <summary>
        /// Campo que contiene la información del peso en libras del paciente.
        /// </summary>
        public int peci_peso { get; set; }
        public bool paci_EsEliminado { get; set; }
        public int paci_UsuarioRegistra { get; set; }
        public DateTime paci_FechaRegistra { get; set; }
        public int? paci_UsuarioModifica { get; set; }
        public DateTime? paci_FechaModifica { get; set; }

        public virtual tbEmpresas emps { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbTiposSangre tipsan { get; set; }
        public virtual ICollection<tbCitas> tbCitas { get; set; }
        public virtual ICollection<tbFrecuenciasCardiacas> tbFrecuenciasCardiacas { get; set; }
        public virtual ICollection<tbPacientes_tbAlergias> tbPacientes_tbAlergias { get; set; }
        public virtual ICollection<tbPacientes_tbCirugias> tbPacientes_tbCirugias { get; set; }
    }
}
