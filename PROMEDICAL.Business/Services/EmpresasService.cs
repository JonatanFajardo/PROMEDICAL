using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    public class EmpresasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public EmpresasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<UDP_Empresas_FindResult> repositoryResult = await _unitOfWork.Empresas.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<Empresas_SelectDto>>(repositoryResult.ToList());
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
                UDP_Empresas_FindResult repositoryResult = await _unitOfWork.Empresas.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<Empresas_FindDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(Empresas_CreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                // Validacion de pers_Identidad
                IEnumerable<UDP_Empresas_FindResult> UQIdentidad = await _unitOfWork.Empresas.ListAsync();
                // Se hace una busqueda por identidad y si retorna diferente de nulo indicaria que ya existe.
                if (!UQIdentidad.Where(x => x.emps_RTN == dto.emps_RTN).ToList().Count.Equals(0))
                    return apiServiceResult.Error("El campo emps_RTN ya se ha implementado.");

                // Actualizar
                tbEmpresas mappedResult = MappingCustom.Map(dto);
                apiServiceResult.Success = await _unitOfWork.Empresas.AddAsync(mappedResult);
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

        public async Task<ServiceResult> EditAsync(Empresas_UpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbEmpresas mappedResult = MappingCustom.Map(dto);
                apiServiceResult.Success = await _unitOfWork.Empresas.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.Empresas.RemoveAsync(id);
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
