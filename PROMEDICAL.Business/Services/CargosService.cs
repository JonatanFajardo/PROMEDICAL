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
    public class CargosService
    {
        //private readonly CargosRepository _CargosRepository;

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CargosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbCargos> repositoryResult = await _unitOfWork.Cargos.ListAsync();
                apiServiceResult.Data = _mapper.Map <List<CargosDto>>(repositoryResult.ToList());
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
                tbCargos repositoryResult = await _unitOfWork.Cargos.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<CargosDto>(repositoryResult.ToList());
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
                tbCargos repositoryResult = await _unitOfWork.Cargos.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<CargosDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(CargosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbCargos mappedResult = _mapper.Map<tbCargos>(dto);
                apiServiceResult.Success = await _unitOfWork.Cargos.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(CargosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {

                tbCargos mappedResult = _mapper.Map<tbCargos>(dto);
                apiServiceResult.Success = await _unitOfWork.Cargos.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok($"actualizada exitosamente.");
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
                apiServiceResult.Success = await _unitOfWork.Cargos.RemoveAsync(id);
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
