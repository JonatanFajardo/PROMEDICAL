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
    public class EspecialidadesService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public EspecialidadesService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }

        public async Task<ServiceResult> ListAsync()
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbEspecialidades> repositoryResult = await _unitOfWork.Especialidades.ListAsync();
                apiServiceResult.Data = _mapper.Map<List<EspecialidadesDto>>(repositoryResult.ToList());
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
                tbEspecialidades repositoryResult = await _unitOfWork.Especialidades.FindAsync(id);
                apiServiceResult.Data = _mapper.Map<EspecialidadesDto>(repositoryResult);
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
                return apiServiceResult.Ok(await _unitOfWork.Especialidades.DetailAsync(id));
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(EspecialidadesDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbEspecialidades mappedResult = _mapper.Map<tbEspecialidades>(dto);
                apiServiceResult.Success = await _unitOfWork.Especialidades.AddAsync(mappedResult);
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
        public async Task<ServiceResult> EditAsync(EspecialidadesDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbEspecialidades mappedResult = _mapper.Map<tbEspecialidades>(dto);
                apiServiceResult.Success = await _unitOfWork.Especialidades.EditAsync(mappedResult);
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

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                apiServiceResult.Success = await _unitOfWork.Especialidades.RemoveAsync(id);
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
