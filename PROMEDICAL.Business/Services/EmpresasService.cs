using AutoMapper;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    public class EmpresasService
    {
        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;

        //public EmpresasService(IUnitOfWork IUnitOfWork, IMapper mapper)
        //{
        //    _mapper = mapper;
        //    _unitOfWork = IUnitOfWork;
        //}
        //public async Task<ApiServiceResult> ListAsync()
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {
        //        IEnumerable<tbEmpresas> repositoryResult = await _unitOfWork.Empresas.ListAsync();
        //        apiServiceResult.Data = _mapper.Map<List<EmpresasDto>(serviceResult);
                //return apiServiceResult.Ok(apiServiceResult);
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

        //public async Task<ApiServiceResult> FindAsync(int id)
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {
        //        tbEmpresas repositoryResult = await _unitOfWork.Empresas.FindAsync(id);
        //        apiServiceResult.Data = _mapper.Map<EmpresasDto>(serviceResult);
                //return apiServiceResult.Ok(apiServiceResult);
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

        //public async Task<ApiServiceResult> DetailAsync(int id)
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {
        //        tbEmpresas repositoryResult = await _unitOfWork.Empresas.DetailAsync(id);
        //        apiServiceResult.Data = _mapper.Map<EmpresasDto>(serviceResult);
                //return apiServiceResult.Ok(apiServiceResult);
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

        //public async Task<ApiServiceResult> AddAsync(EmpresasDto dto)
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {
        //        tbEmpresas mappedResult = _mapper.Map<tbEmpresas>(dto);
        //        apiServiceResult.Success = await _unitOfWork.Empresas.AddAsync(mappedResult);
        //        if (!apiServiceResult.Success)
        //            return apiServiceResult.Ok();
        //        else
        //            return apiServiceResult.Error();
        //        throw new NotImplementedException();

        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}
        //public async Task<ApiServiceResult> EditAsync(EmpresasDto dto)
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {

        //        tbEmpresas mappedResult = _mapper.Map<tbEmpresas>(dto);
        //        apiServiceResult.Success = await _unitOfWork.Empresas.EditAsync(mappedResult);
        //        if (!apiServiceResult.Success)
        //            return apiServiceResult.Ok();
        //        else
        //            return apiServiceResult.Error();
        //        throw new NotImplementedException();
        //    }
        //    catch (Exception e)
        //    {
        //        return apiServiceResult.Error();
        //    }
        //}

        //public async Task<ApiServiceResult> DeleteAsync(int id)
        //{
        //    ApiServiceResult apiServiceResult = new ApiServiceResult();

        //    try
        //    {
        //        apiServiceResult.Success = await _unitOfWork.Empresas.RemoveAsync(id);
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
