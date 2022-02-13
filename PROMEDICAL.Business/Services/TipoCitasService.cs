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
    internal class TipoCitasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public TipoCitasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbTipoCitas> serviceResult = await _unitOfWork.TipoCitas.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<TipoCitasDto>(serviceResult));
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
                tbTipoCitas serviceResult = await _unitOfWork.TipoCitas.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<TipoCitasDto>(serviceResult));
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
                tbTipoCitas serviceResult = await _unitOfWork.TipoCitas.DetailAsync(id);
                return apiServiceResult.Ok(_mapper.Map<TipoCitasDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }
        public async Task<ApiServiceResult> AddAsync(TipoCitasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbTipoCitas mappedResult = _mapper.Map<tbTipoCitas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoCitas.AddAsync(mappedResult);
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
        public async Task<ApiServiceResult> EditAsync(TipoCitasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbTipoCitas mappedResult = _mapper.Map<tbTipoCitas>(dto);
                apiServiceResult.Success = await _unitOfWork.TipoCitas.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.TipoCitas.RemoveAsync(id);
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
