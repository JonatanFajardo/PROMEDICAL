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
    public class JornadasServices
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public JornadasServices(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbJornadas> repositoryResult = await _unitOfWork.Jornadas.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<JornadasSelectDto>>(repositoryResult.ToList());
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
                tbJornadas repositoryResult = await _unitOfWork.Jornadas.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<JornadasFindDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> DetailAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbJornadas repositoryResult = await _unitOfWork.Jornadas.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<JornadasDetailDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(JornadasCreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbJornadas mappedResult = _mapper.Map<tbJornadas>(dto);
                apiServiceResult.Success = await _unitOfWork.Jornadas.AddAsync(mappedResult);
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

        public async Task<ServiceResult> EditAsync(JornadasUpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbJornadas mappedResult = _mapper.Map<tbJornadas>(dto);
                apiServiceResult.Success = await _unitOfWork.Jornadas.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Objeto Registro Operación completada exitosamente..");
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
                apiServiceResult.Success = await _unitOfWork.Jornadas.RemoveAsync(id);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Categoría eliminada exitosamente.");
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
