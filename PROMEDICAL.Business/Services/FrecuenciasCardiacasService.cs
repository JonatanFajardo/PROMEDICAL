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
    public class FrecuenciasCardiacasService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public FrecuenciasCardiacasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = IUnitOfWork;
        }
        public async Task<ServiceResult> ListAsync(int id)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                IEnumerable<tbFrecuenciasCardiacas> repositoryResult = await _unitOfWork.FrecuenciasCardiacas.ListAsync(id);
                apiServiceResult.Data = _mapper.Map <List<FrecuenciasCardiacas_SelectDto>>(repositoryResult.ToList());
                if (apiServiceResult.Data == null)
                    return apiServiceResult.Error();

                return apiServiceResult.Ok();
            }
            catch (Exception e)
            {
                return apiServiceResult.Error();
            }
        }

        public async Task<ServiceResult> AddAsync(FrecuenciasCardiacas_CreateDto dto)
        {
            ServiceResult apiServiceResult = new ServiceResult();

            try
            {
                tbFrecuenciasCardiacas mappedResult = _mapper.Map<tbFrecuenciasCardiacas>(dto);
                apiServiceResult.Success = await _unitOfWork.FrecuenciasCardiacas.AddAsync(mappedResult);
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

        //public async Task<ServiceResult> EditAsync(FrecuenciasCardiacas_UpdateDto dto)
        //{
        //    ServiceResult apiServiceResult = new ServiceResult();

        //    try
        //    {

        //        tbFrecuenciasCardiacas mappedResult = _mapper.Map<tbFrecuenciasCardiacas>(dto);
        //        apiServiceResult.Success = await _unitOfWork.FrecuenciasCardiacas.EditAsync(mappedResult);
        //        if (!apiServiceResult.Success)
        //            return apiServiceResult.Ok();
        //        else
        //            return apiServiceResult.Error();
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

        //public async Task<ServiceResult> DeleteAsync(int id)
        //{
        //    ServiceResult apiServiceResult = new ServiceResult();

        //    try
        //    {
        //        apiServiceResult.Success = await _unitOfWork.FrecuenciasCardiacas.RemoveAsync(id);
        //        if (!apiServiceResult.Success)
        //            return apiServiceResult.Ok();
        //        else
        //            return apiServiceResult.Error();
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

    }
}
