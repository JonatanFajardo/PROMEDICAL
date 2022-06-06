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
    public class PrescripcionesService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PrescripcionesService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbPrescripciones> repositoryResult = await _unitOfWork.Prescripciones.ListAsync(id);
                apiServiceResult.Data = _mapper.Map<List<PrescripcionesSelectDto>>(repositoryResult.ToList());
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
                tbPrescripciones repositoryResult = await _unitOfWork.Prescripciones.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<PrescripcionesFindDto>(repositoryResult);
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
                tbPrescripciones repositoryResult = await _unitOfWork.Prescripciones.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<PrescripcionesDetailDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(PrescripcionesCreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbPrescripciones mappedResult = _mapper.Map<tbPrescripciones>(dto);
                apiServiceResult.Success = await _unitOfWork.Prescripciones.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(PrescripcionesUpdateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbPrescripciones mappedResult = _mapper.Map<tbPrescripciones>(dto);
                apiServiceResult.Success = await _unitOfWork.Prescripciones.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.Prescripciones.RemoveAsync(id);
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
