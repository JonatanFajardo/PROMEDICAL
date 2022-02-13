using PROMEDICAL.Logic.Interfaces.Especific;
using PROMEDICAL.Logic.Interfaces.General;

namespace PROMEDICAL.Logic.Repositories.General
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICargosRepository cargosRepository)
        {
            Cargos = cargosRepository;
        }
        public ICargosRepository Cargos { get; }
        public IPrescripcionesRepository Prescripciones { get; }
        public ITipoCitasRepository TipoCitas { get; }
        public ITipoConsultasRepository TipoConsultas { get; }
        public IConsultoriosRepository Consultorios { get; }
        public IEspecialidadesRepository Especialidades { get; }
        public IJornadasRepository Jornadas { get; }
        public IMedicamentosRepository Medicamentos { get; }
        public IPesosRepository Pesos { get; }
        public ICirugiasRepository Cirugias { get; }

        public ICitasRepository Citas { get; }
        public IEmpleadosRepository Empleados { get; }
        public IEmpresasRepository Empresas { get; }
        public IFrecuenciasCardiacasRepository FrecuenciasCardiacas { get; }
        public IPacientesRepository Pacientes { get; }
        public IPersonasRepository Personas { get; }

    }
}
