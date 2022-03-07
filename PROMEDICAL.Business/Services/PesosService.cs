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
    public class PesosService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PesosService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbPesos> repositoryResult = await _unitOfWork.Pesos.ListAsync();
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
                tbPesos repositoryResult = await _unitOfWork.Pesos.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<PesosDto>(repositoryResult);
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
                tbPesos repositoryResult = await _unitOfWork.Pesos.DetailAsync(id);
                apiServiceResult.Data = _mapper.Map<PesosDto>(repositoryResult);
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }


        public async Task<ServiceResult> AddAsync(PesosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbPesos mappedResult = _mapper.Map<tbPesos>(dto);
                apiServiceResult.Success = await _unitOfWork.Pesos.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(PesosDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbPesos mappedResult = _mapper.Map<tbPesos>(dto);
                apiServiceResult.Success = await _unitOfWork.Pesos.EditAsync(mappedResult);
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
                apiServiceResult.Success = await _unitOfWork.Pesos.RemoveAsync(id);
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
