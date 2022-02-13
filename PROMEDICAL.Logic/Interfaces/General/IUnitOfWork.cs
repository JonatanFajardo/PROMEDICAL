using PROMEDICAL.Logic.Interfaces.Especific;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Logic.Interfaces.General
{
    public interface IUnitOfWork
    {

        IPrescripcionesRepository Prescripciones { get; }
        ITipoCitasRepository TipoCitas { get; }
        ITipoConsultasRepository TipoConsultas { get; }
        ICargosRepository Cargos { get; }
        ICirugiasRepository Cirugias { get; }
        IConsultoriosRepository Consultorios { get; }
        IEspecialidadesRepository Especialidades { get; }
        IJornadasRepository Jornadas { get; }
        IMedicamentosRepository Medicamentos { get; }
        IPesosRepository Pesos { get; }

        ICitasRepository Citas { get; }
        IEmpleadosRepository Empleados { get; }
        IEmpresasRepository Empresas { get; }
        IFrecuenciasCardiacasRepository FrecuenciasCardiacas { get; }
        IPacientesRepository Pacientes { get; }
        IPersonasRepository Personas { get; }
    }
}
