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
            // Empleados
            CreateMap<tbEmpleados, EmpleadosDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, tbEmpleados>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_CreateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_UpdateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_FindDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, UDP_Empleados_SelectResult>().ReverseMap();
            // Citas
            CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, tbCitas>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, Citas_CreateDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, Citas_UpdateDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, Citas_FindDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, UDP_Citas_SelectResult>().ReverseMap();

            CreateMap<tbEmpresas, EmpresasDto>().ReverseMap();
            CreateMap<tbTiposSangre, TiposSangreDto>().ReverseMap();
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
