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
    internal class ConsultoriosService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ConsultoriosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbConsultorios> serviceResult = await _unitOfWork.Consultorios.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<ConsultoriosDto>(serviceResult));
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
                tbConsultorios serviceResult = await _unitOfWork.Consultorios.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<ConsultoriosDto>(serviceResult));
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
                tbConsultorios serviceResult = await _unitOfWork.Consultorios.DetailAsync(id);
                return apiServiceResult.Ok(_mapper.Map<ConsultoriosDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(ConsultoriosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbConsultorios mappedResult = _mapper.Map<tbConsultorios>(dto);
                apiServiceResult.Success = await _unitOfWork.Consultorios.AddAsync(mappedResult);
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
        public async Task<ApiServiceResult> EditAsync(ConsultoriosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbConsultorios mappedResult = _mapper.Map<tbConsultorios>(dto);
                apiServiceResult.Success = await _unitOfWork.Consultorios.EditAsync(mappedResult);
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
