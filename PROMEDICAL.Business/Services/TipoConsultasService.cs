using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    public class TipoConsultasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public TipoConsultasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.ListAsync());
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
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.FindAsync(id));
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
                return apiServiceResult.Ok(await _unitOfWork.TipoConsultas.DetailAsync(id));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(TipoConsultas_CreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbTipoConsultas mappedResult = _mapper.Map<tbTipoConsultas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoConsultas.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(TipoConsultas_UpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbTipoConsultas mappedResult = _mapper.Map<tbTipoConsultas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoConsultas.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.TipoConsultas.RemoveAsync(id);
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
