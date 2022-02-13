using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    internal class CargosService
    {
        //private readonly CargosRepository _CargosRepository;

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CargosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbCargos> serviceResult = await _unitOfWork.Cargos.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<CargosDto>(serviceResult));
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
                tbCargos serviceResult = await _unitOfWork.Cargos.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<CargosDto>(serviceResult));
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
                tbCargos serviceResult = await _unitOfWork.Cargos.DetailAsync(id);
                return apiServiceResult.Ok(_mapper.Map<CargosDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(CargosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbCargos mappedResult = _mapper.Map<tbCargos>(dto);
                apiServiceResult.Success = await _unitOfWork.Cargos.AddAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok($"creada exitosamente.");
                else
                    return apiServiceResult.Error();
                throw new NotImplementedException();

            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }
        public async Task<ApiServiceResult> EditAsync(CargosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {

                tbCargos mappedResult = _mapper.Map<tbCargos>(dto);
                apiServiceResult.Success = await _unitOfWork.Cargos.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok($"actualizada exitosamente.");
                else
                    return apiServiceResult.Error();
                throw new NotImplementedException();
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
