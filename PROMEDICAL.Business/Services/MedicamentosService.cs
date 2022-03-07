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
    public class MedicamentosService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MedicamentosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbMedicamentos> repositoryResult = await _unitOfWork.Medicamentos.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<MedicamentosDto>>(repositoryResult.ToList());
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
                tbMedicamentos repositoryResult = await _unitOfWork.Medicamentos.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<MedicamentosDto>(repositoryResult);
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
                tbMedicamentos repositoryResult = await _unitOfWork.Medicamentos.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<MedicamentosDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(MedicamentosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbMedicamentos mappedResult = _mapper.Map<tbMedicamentos>(dto);
                apiServiceResult.Success = await _unitOfWork.Medicamentos.AddAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Objeto Registro guardado exitosamente.");
                else
                    return apiServiceResult.Error();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }
        public async Task<ServiceResult> EditAsync(MedicamentosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbMedicamentos mappedResult = _mapper.Map<tbMedicamentos>(dto);
                apiServiceResult.Success = await _unitOfWork.Medicamentos.EditAsync(mappedResult);
                if (!apiServiceResult.Success)
                    return apiServiceResult.Ok("Objeto Registro Operación completada exitosamente..");
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
                apiServiceResult.Success = await _unitOfWork.Medicamentos.RemoveAsync(id);
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
