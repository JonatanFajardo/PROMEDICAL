using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using PROMEDICAL.Logic.Repositories.General;
using System;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    internal class TipoConsultasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public TipoConsultasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.ListAsync());
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
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.FindAsync(id));
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
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.DetailAsync(id));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(TipoConsultasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbTipoConsultas mappedResult = _mapper.Map<tbTipoConsultas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoConsultas.AddAsync(mappedResult);
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
        public async Task<ApiServiceResult> EditAsync(TipoConsultasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbTipoConsultas mappedResult = _mapper.Map<tbTipoConsultas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoConsultas.EditAsync(mappedResult);
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
    }
}
