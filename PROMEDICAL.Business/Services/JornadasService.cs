using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using PROMEDICAL.Logic.Repositories.General;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    internal class JornadasServices
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public JornadasServices(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbJornadas> serviceResult = await _unitOfWork.Jornadas.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<JornadasDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> FindAsync(int id)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbJornadas serviceResult = await _unitOfWork.Jornadas.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<JornadasDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> DetailAsync(int id)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbJornadas serviceResult = await _unitOfWork.Jornadas.DetailAsync(id);
                return apiServiceResult.Ok(_mapper.Map<JornadasDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(JornadasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbJornadas mappedResult = _mapper.Map<tbJornadas>(dto);
                apiServiceResult.Success = await _unitOfWork.Jornadas.AddAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Objeto creada exitosamente.");
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> EditAsync(JornadasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbJornadas mappedResult = _mapper.Map<tbJornadas>(dto);
                apiServiceResult.Success = await _unitOfWork.Jornadas.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Objeto actualizada exitosamente.");
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> DeleteAsync(int id)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

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
