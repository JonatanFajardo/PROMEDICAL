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
    internal class MedicamentosService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MedicamentosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ApiServiceResult> ListAsync()
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                IEnumerable<tbMedicamentos> serviceResult = await _unitOfWork.Medicamentos.ListAsync();
                return apiServiceResult.Ok(_mapper.Map<MedicamentosDto>(serviceResult));
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
                tbMedicamentos serviceResult = await _unitOfWork.Medicamentos.FindAsync(id);
                return apiServiceResult.Ok(_mapper.Map<MedicamentosDto>(serviceResult));
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
                tbMedicamentos serviceResult = await _unitOfWork.Medicamentos.DetailAsync(id);
                return apiServiceResult.Ok(_mapper.Map<MedicamentosDto>(serviceResult));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ApiServiceResult> AddAsync(MedicamentosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbMedicamentos mappedResult = _mapper.Map<tbMedicamentos>(dto);
                apiServiceResult.Success = await _unitOfWork.Medicamentos.AddAsync(mappedResult);
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
        public async Task<ApiServiceResult> EditAsync(MedicamentosDto dto)
        {
            ApiServiceResult apiServiceResult = new ApiServiceResult();

            try
            {
                tbMedicamentos mappedResult = _mapper.Map<tbMedicamentos>(dto);
                apiServiceResult.Success = await _unitOfWork.Medicamentos.EditAsync(mappedResult);
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
