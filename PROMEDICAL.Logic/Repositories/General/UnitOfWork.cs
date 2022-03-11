using PROMEDICAL.Logic.Interfaces.Especific;
using PROMEDICAL.Logic.Interfaces.General;

namespace PROMEDICAL.Logic.Repositories.General
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICargosRepository cargosRepository,
            IAlergiasRepository AlergiasRepository,
            ICargosRepository CargosRepository,
            IPrescripcionesRepository PrescripcionesRepository,
            ITipoCitasRepository TipoCitasRepository,
            ITipoConsultasRepository TipoConsultasRepository,
            IConsultoriosRepository ConsultoriosRepository,
            ITiposSangreRepository TiposSangreRepository,
            IJornadasRepository JornadasRepository,
            IMedicamentosRepository MedicamentosRepository,
            IPesosRepository PesosRepository,
            ICirugiasRepository CirugiasRepository,
            ICitasRepository CitasRepository,
            IEmpleadosRepository EmpleadosRepository,
            IEmpresasRepository EmpresasRepository,
            IFrecuenciasCardiacasRepository FrecuenciasCardiacasRepository,
            IPacientesRepository PacientesRepository)
        {
            Cargos = cargosRepository;
            Alergias = AlergiasRepository;
            Cargos = CargosRepository;
            Prescripciones = PrescripcionesRepository;
            TipoCitas = TipoCitasRepository;
            TipoConsultas = TipoConsultasRepository;
            Consultorios = ConsultoriosRepository;
            TiposSangre = TiposSangreRepository;
            Jornadas = JornadasRepository;
            Medicamentos = MedicamentosRepository;
            Pesos = PesosRepository;
            Cirugias = CirugiasRepository;
            Citas = CitasRepository;
            Empleados = EmpleadosRepository;
            Empresas = EmpresasRepository;
            FrecuenciasCardiacas = FrecuenciasCardiacasRepository;
            Pacientes = PacientesRepository;
        }
        public IAlergiasRepository Alergias { get; }
        public ICargosRepository Cargos { get; }
        public IPrescripcionesRepository Prescripciones { get; }
        public ITipoCitasRepository TipoCitas { get; }
        public ITipoConsultasRepository TipoConsultas { get; }
        public IConsultoriosRepository Consultorios { get; }
        public ITiposSangreRepository TiposSangre { get; }
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
