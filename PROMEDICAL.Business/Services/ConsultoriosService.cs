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
    public class ConsultoriosService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ConsultoriosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbConsultorios> repositoryResult = await _unitOfWork.Consultorios.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<ConsultoriosSelectDto>>(repositoryResult.ToList());
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
                tbConsultorios repositoryResult = await _unitOfWork.Consultorios.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<ConsultoriosFindDto>(repositoryResult);
                if (apiServiceResult.Data = null)
                {
                    apiServiceResult.Success = false;
                    apiServiceResult.Error();
                    return apiServiceResult;
                }

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
                tbConsultorios repositoryResult = await _unitOfWork.Consultorios.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<ConsultoriosDetailDto>(repositoryResult);
                if (apiServiceResult.Data = null)
                {
                    apiServiceResult.Success = false;
                    apiServiceResult.Error();
                    return apiServiceResult;
                }

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(ConsultoriosCreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbConsultorios mappedResult = _mapper.Map<tbConsultorios>(dto);
                apiServiceResult.Success = await _unitOfWork.Consultorios.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(ConsultoriosUpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbConsultorios mappedResult = _mapper.Map<tbConsultorios>(dto);
                apiServiceResult.Success = await _unitOfWork.Consultorios.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.Consultorios.RemoveAsync(id);
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
