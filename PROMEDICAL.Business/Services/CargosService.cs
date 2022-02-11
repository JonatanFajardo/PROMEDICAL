using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Logic.Repositories.General;
using System;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Services
{
    internal class CargosService
    {
        //private readonly CargosRepository _CargosRepository;
        private UnitOfWork _unitOfWork;
        public CargosService(UnitOfWork unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<ApiServiceResult> ListAsync()
        {
            var result = new ApiServiceResult();

            try
            {
                return result.Ok(await _unitOfWork.cargos.ListAsync());
            }
            catch (Exception e)
            {
                return result.Error($"Se produjo un error: {e.Message}");
            }
        }

        public async Task<ApiServiceResult> FindAsync(int id)
        {
            var result = new ApiServiceResult();

            try
            {
                return result.Ok(await _unitOfWork.cargos.FindAsync(id));
            }
            catch (Exception e)
            {
                return result.Error($"Se produjo un error: {e.Message}");
            }
        }
        
        public async Task<ApiServiceResult> AddAsync(CargosDto model)
        {
            var result = new ApiServiceResult();

            try
            {

                //int resultado = await _unitOfWork.cargos.AddAsync(model);
                //if (resultado == 1)
                //    return result.Ok($"creada exitosamente.");
                //else
                //    return result.Error($"Se produjo un error.");
                throw new NotImplementedException();

            }
            catch (Exception e)
            {
                return result.Error($"Se produjo un error: {e.Message}");
            }
        }
        public async Task<ApiServiceResult> UpdateAsync(CargosDto model)
        {
            var result = new ApiServiceResult();

            try
            {
                //int resultado = await _unitOfWork.cargos.EditAsync(model);
                //if (resultado == 1)
                //    return result.Ok($"actualizada exitosamente.");
                //else
                //    return result.Error($"Se produjo un error.");
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                return result.Error($"Se produjo un error: {e.Message}");
            }
        }

        public async Task<ApiServiceResult> DeleteAsync(int id)
        {
            var result = new ApiServiceResult();

            try
            {
                //int resultado = await _unitOfWork.cargos.RemoveAsync(id);
                //if (resultado == 1)
                //    return result.Ok("Categoría eliminada exitosamente.");
                //else
                //    return result.Error("Se produjo un error.");
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                return result.Error($"Se produjo un error: {e.Message}");
            }
        }

    }
}
