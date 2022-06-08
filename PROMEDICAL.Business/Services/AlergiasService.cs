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
    public class AlergiasService
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AlergiasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            IEnumerable<tbAlergias> repositoryResult = await _unitOfWork.Alergias.ListAsync();
            apiServiceResult.Data = _mapper.Map<List<AlergiasUpdateDto>>(repositoryResult.ToList());
            //if (apiServiceResult.Data == null)
            //    return apiServiceResult.Error();

            return apiServiceResult.Ok();
        }

        public async Task<ServiceResult> FindAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbAlergias repositoryResult = await _unitOfWork.Alergias.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<AlergiasUpdateDto>(repositoryResult);
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
                tbAlergias repositoryResult = await _unitOfWork.Alergias.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<AlergiasUpdateDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(AlergiasCreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbAlergias mappedResult = _mapper.Map<tbAlergias>(dto);
                apiServiceResult.Success = await _unitOfWork.Alergias.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(AlergiasUpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {

                tbAlergias mappedResult = _mapper.Map<tbAlergias>(dto);
                apiServiceResult.Success = await _unitOfWork.Alergias.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.Alergias.RemoveAsync(id);
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
