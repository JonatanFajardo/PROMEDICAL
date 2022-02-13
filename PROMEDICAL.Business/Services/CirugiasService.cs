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
    internal class CirugiasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CirugiasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbCirugias> serviceResult = await _unitOfWork.Cirugias.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<CirugiasDto>(serviceResult));
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
                tbCirugias serviceResult = await _unitOfWork.Cirugias.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<CirugiasDto>(serviceResult));
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

                return apiServiceResult.Ok(await _unitOfWork.Cirugias.DetailAsync(id));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(CirugiasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbCirugias mappedResult = _mapper.Map<tbCirugias>(dto);
                apiServiceResult.Success = await _unitOfWork.Cirugias.AddAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok($"creada exitosamente.");
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }
        public async Task<ApiServiceResult> EditAsync(CirugiasDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbCirugias mappedResult = _mapper.Map<tbCirugias>(dto);
                apiServiceResult.Success = await _unitOfWork.Cirugias.EditAsync(mappedResult);
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
                    apiServiceResult.Success = await _unitOfWork.Cirugias.RemoveAsync(id);
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
