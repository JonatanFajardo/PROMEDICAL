using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Entities.Entities;

namespace PROMEDICAL.Business.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<tbAlergias, Alergias_UpdateDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_CreateDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_CreateDto>().ReverseMap();
            CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_CreateDto>().ReverseMap();
            // Empleados
            CreateMap<tbEmpleados, EmpleadosDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, tbEmpleados>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_CreateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_UpdateDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, Empleados_DetailDto>().ReverseMap();
            CreateMap<UDP_Empleados_FindResult, UDP_Empleados_SelectResult>().ReverseMap();
            // Pacientes
            CreateMap<UDP_Pacientes_FindResult, tbPacientes>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, Pacientes_CreateDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, Pacientes_UpdateDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, Pacientes_SelectDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, Pacientes_FindDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, Pacientes_DetailDto>().ReverseMap();
            CreateMap<UDP_Pacientes_FindResult, UDP_Pacientes_SelectResult>().ReverseMap();
            // Citas
            //CreateMap<tbCitas, CitasDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, tbCitas>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, Citas_CreateDto>().ReverseMap();
            //CreateMap<UDP_Citas_FindResult, Citas_UpdateDto>().ReverseMap();
            //CreateMap<UDP_Citas_FindResult, Citas_FindDto>().ReverseMap();
            CreateMap<UDP_Citas_FindResult, UDP_Citas_SelectResult>().ReverseMap();
            //Empresas
            CreateMap<tbEmpresas, Empresas_CreateDto>().ReverseMap();
            CreateMap<tbEmpresas, Empresas_UpdateDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, Empresas_SelectDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, Empresas_FindDto>().ReverseMap();
            CreateMap<UDP_Empresas_FindResult, Empresas_DetailDto>().ReverseMap();
            //CreateMap<tbEmpresas, Empresas_DeleteDto>().ReverseMap();


            CreateMap<tbTiposSangre, TiposSangre_UpdateDto>().ReverseMap();
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacasDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_CreateDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_UpdateDto>().ReverseMap();
            CreateMap<tbPacientes, PacientesDto>().ReverseMap();
            //CreateMap<tbPacientes_tbAlergias, Pacientes_tbAlergiasDto>().ReverseMap();
            //CreateMap<tbPacientes_tbCirugias, Pacientes_tbCirugiasDto>().ReverseMap();
            CreateMap<tbPersonas, PersonasDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_CreateDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_CreateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_CreateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_UpdateDto>().ReverseMap();



            //FrecuenciasCardiacas
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_CreateDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_UpdateDto>().ReverseMap();
            CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_SelectDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_FindDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_DetailDto>().ReverseMap();
            //CreateMap<tbFrecuenciasCardiacas, FrecuenciasCardiacas_DeleteDto>().ReverseMap();
            //Alergias
            CreateMap<tbAlergias, Alergias_CreateDto>().ReverseMap();
            CreateMap<tbAlergias, Alergias_UpdateDto>().ReverseMap();
            CreateMap<tbAlergias, Alergias_SelectDto>().ReverseMap();
            CreateMap<tbAlergias, Alergias_FindDto>().ReverseMap();
            CreateMap<tbAlergias, Alergias_DetailDto>().ReverseMap();
            CreateMap<tbAlergias, Alergias_DeleteDto>().ReverseMap();
            //Cargos
            CreateMap<tbCargos, Cargos_CreateDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_UpdateDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_SelectDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_FindDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_DetailDto>().ReverseMap();
            CreateMap<tbCargos, Cargos_DeleteDto>().ReverseMap();
            //Cirugias
            CreateMap<tbCirugias, Cirugias_CreateDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_UpdateDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_SelectDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_FindDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_DetailDto>().ReverseMap();
            CreateMap<tbCirugias, Cirugias_DeleteDto>().ReverseMap();
            //Consultorios
            CreateMap<tbConsultorios, Consultorios_CreateDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_UpdateDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_SelectDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_FindDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_DetailDto>().ReverseMap();
            CreateMap<tbConsultorios, Consultorios_DeleteDto>().ReverseMap();
            //Jornadas
            CreateMap<tbJornadas, Jornadas_CreateDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_UpdateDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_SelectDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_FindDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_DetailDto>().ReverseMap();
            CreateMap<tbJornadas, Jornadas_DeleteDto>().ReverseMap();
            //Medicamentos
            CreateMap<tbMedicamentos, Medicamentos_CreateDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_UpdateDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_SelectDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_FindDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_DetailDto>().ReverseMap();
            CreateMap<tbMedicamentos, Medicamentos_DeleteDto>().ReverseMap();
            //Pesos
            CreateMap<tbPesos, Pesos_CreateDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_UpdateDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_SelectDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_FindDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_DetailDto>().ReverseMap();
            CreateMap<tbPesos, Pesos_DeleteDto>().ReverseMap();
            //Prescripciones
            CreateMap<tbPrescripciones, Prescripciones_CreateDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_UpdateDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_SelectDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_FindDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_DetailDto>().ReverseMap();
            CreateMap<tbPrescripciones, Prescripciones_DeleteDto>().ReverseMap();
            //TipoCitas
            CreateMap<tbTipoCitas, TipoCitas_CreateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_UpdateDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_SelectDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_FindDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_DetailDto>().ReverseMap();
            CreateMap<tbTipoCitas, TipoCitas_DeleteDto>().ReverseMap();
            //TipoConsultas
            CreateMap<tbTipoConsultas, TipoConsultas_CreateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_UpdateDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_SelectDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_FindDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_DetailDto>().ReverseMap();
            CreateMap<tbTipoConsultas, TipoConsultas_DeleteDto>().ReverseMap();

        }
    }
}
