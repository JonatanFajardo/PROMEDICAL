using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Entities.Entities;

namespace PROMEDICAL.Business.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<tbAlergias, AlergiasUpdateDto>().ReverseMap();
            CreateMap<tbCargos, CargosCreateDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasCreateDto>().ReverseMap();
            CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosCreateDto>().ReverseMap();
            // Empleados
            CreateMap<tbEmpleados, EmpleadosDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, tbEmpleados>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, EmpleadosCreateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, EmpleadosUpdateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, EmpleadosDetailDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, UDP_Empleados_SelectResult>().ReverseMap();
            // Pacientes
            CreateMap<UDP_Pacientes_FindResult, tbPacientes>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, PacientesCreateDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, PacientesUpdateDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, PacientesSelectDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, PacientesFindDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, PacientesDetailDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, UDP_Pacientes_SelectResult>().ReverseMap();
            // Citas
            //CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, tbCitas>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, CitasCreateDto>().ReverseMap();
            //CreateMap<UDP_Citas_FindResult, CitasUpdateDto>().ReverseMap();
            //CreateMap<UDP_Citas_FindResult, CitasFindDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, UDP_Citas_SelectResult>().ReverseMap();
            //Empresas
            CreateMap<tbEmpresas, EmpresasCreateDto>().ReverseMap();
            CreateMap<tbEmpresas, EmpresasUpdateDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, EmpresasSelectDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, EmpresasFindDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, EmpresasDetailDto>().ReverseMap();
            //CreateMap<tbEmpresas, EmpresasDeleteDto>().ReverseMap();


            CreateMap<tbTiposSangre, TiposSangreUpdateDto>().ReverseMap();
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasCreateDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosUpdateDto>().ReverseMap();
            CreateMap<tbPacientes, PacientesDto>().ReverseMap();
            //CreateMap<tbPacientes_tbAlergias, Pacientes_tbAlergiasDto>().ReverseMap();
            //CreateMap<tbPacientes_tbCirugias, Pacientes_tbCirugiasDto>().ReverseMap();
            CreateMap<tbPersonas, PersonasDto>().ReverseMap();
            CreateMap<tbPesos, PesosCreateDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesCreateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasCreateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasUpdateDto>().ReverseMap();



            //FrecuenciasCardiacas
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasCreateDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasUpdateDto>().ReverseMap();
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasSelectDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasFindDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasDetailDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasDeleteDto>().ReverseMap();
            //Alergias
            CreateMap<tbAlergias, AlergiasCreateDto>().ReverseMap();
            CreateMap<tbAlergias, AlergiasUpdateDto>().ReverseMap();
            CreateMap<tbAlergias, AlergiasSelectDto>().ReverseMap();
            CreateMap<tbAlergias, AlergiasFindDto>().ReverseMap();
            CreateMap<tbAlergias, AlergiasDetailDto>().ReverseMap();
            CreateMap<tbAlergias, AlergiasDeleteDto>().ReverseMap();
            //Cargos
            CreateMap<tbCargos, CargosCreateDto>().ReverseMap();
            CreateMap<tbCargos, CargosUpdateDto>().ReverseMap();
            CreateMap<tbCargos, CargosSelectDto>().ReverseMap();
            CreateMap<tbCargos, CargosFindDto>().ReverseMap();
            CreateMap<tbCargos, CargosDetailDto>().ReverseMap();
            CreateMap<tbCargos, CargosDeleteDto>().ReverseMap();
            //Cirugias
            CreateMap<tbCirugias, CirugiasCreateDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasUpdateDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasSelectDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasFindDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasDetailDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasDeleteDto>().ReverseMap();
            //Consultorios
            CreateMap<tbConsultorios, ConsultoriosCreateDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosUpdateDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosSelectDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosFindDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosDetailDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosDeleteDto>().ReverseMap();
            //Jornadas
            CreateMap<tbJornadas, JornadasCreateDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasUpdateDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasSelectDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasFindDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasDetailDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasDeleteDto>().ReverseMap();
            //Medicamentos
            CreateMap<tbMedicamentos, MedicamentosCreateDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosUpdateDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosSelectDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosFindDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosDetailDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosDeleteDto>().ReverseMap();
            //Pesos
            CreateMap<tbPesos, PesosCreateDto>().ReverseMap();
            CreateMap<tbPesos, PesosUpdateDto>().ReverseMap();
            CreateMap<tbPesos, PesosSelectDto>().ReverseMap();
            CreateMap<tbPesos, PesosFindDto>().ReverseMap();
            CreateMap<tbPesos, PesosDetailDto>().ReverseMap();
            CreateMap<tbPesos, PesosDeleteDto>().ReverseMap();
            //Prescripciones
            CreateMap<tbPrescripciones, PrescripcionesCreateDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesUpdateDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesSelectDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesFindDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesDetailDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesDeleteDto>().ReverseMap();
            //TipoCitas
            CreateMap<tbTipoCitas, TipoCitasCreateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasUpdateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasSelectDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasFindDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasDetailDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasDeleteDto>().ReverseMap();
            //TipoConsultas
            CreateMap<tbTipoConsultas, TipoConsultasCreateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasUpdateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasSelectDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasFindDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasDetailDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasDeleteDto>().ReverseMap();

        }
    }
}
