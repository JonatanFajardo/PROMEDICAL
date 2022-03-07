using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Entities.Entities;

namespace PROMEDICAL.Business.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<tbAlergias, AlergiasDto>().ReverseMap();
            CreateMap<tbCargos, CargosDto>().ReverseMap();
            CreateMap<tbCirugias, CirugiasDto>().ReverseMap();
            CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<tbConsultorios, ConsultoriosDto>().ReverseMap();
            CreateMap<tbEmpleados, EmpleadosDto>().ReverseMap();
            CreateMap<tbEmpresas, EmpresasDto>().ReverseMap();
            CreateMap<tbEspecialidades, EspecialidadesDto>().ReverseMap();
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasDto>().ReverseMap();
            CreateMap<tbJornadas, JornadasDto>().ReverseMap();
            CreateMap<tbMedicamentos, MedicamentosDto>().ReverseMap();
            CreateMap<tbPacientes, PacientesDto>().ReverseMap();
            //CreateMap<tbPacientes_tbAlergias, Pacientes_tbAlergiasDto>().ReverseMap();
            //CreateMap<tbPacientes_tbCirugias, Pacientes_tbCirugiasDto>().ReverseMap();
            CreateMap<tbPersonas, PersonasDto>().ReverseMap();
            CreateMap<tbPesos, PesosDto>().ReverseMap();
            CreateMap<tbPrescripciones, PrescripcionesDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitasDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultasDto>().ReverseMap();
        }
    }
}
