using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    public class EmpleadosService
    {
        //private readonly EmpleadosRepository _EmpleadosRepository;

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public EmpleadosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<UDP_Empleados_FindResult> repositoryResult = await _unitOfWork.Empleados.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<UDP_Empleados_SelectResult>>(repositoryResult.ToList());
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> FindAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                UDP_Empleados_FindResult repositoryResult = await _unitOfWork.Empleados.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<UDP_Empleados_FindResult>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(EmpleadosCreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                // Validacion de pers_Identidad
                IEnumerable<UDP_Empleados_FindResult> UQIdentidad = await _unitOfWork.Empleados.ListAsync();
                // Se hace una busqueda por identidad y si retorna diferente de nulo indicaria que ya existe.
                if (!UQIdentidad.Where(x => x.pers_Identidad == dto.pers_Identidad).ToList().Count.Equals(0))
                    return apiServiceResult.Error("El campo pers_Identidad ya se ha implementado.");

                // Actualizar
                tbEmpleados mappedResult = MappingCustom.Map(dto);
                apiServiceResult.Success = await _unitOfWork.Empleados.AddAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok();
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }
        public async Task<ServiceResult> EditAsync(EmpleadosUpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbEmpleados mappedResult = MappingCustom.Map(dto);
                apiServiceResult.Success = await _unitOfWork.Empleados.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok();
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                apiServiceResult.Success = await _unitOfWork.Empleados.RemoveAsync(id);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok();
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

    }
}
