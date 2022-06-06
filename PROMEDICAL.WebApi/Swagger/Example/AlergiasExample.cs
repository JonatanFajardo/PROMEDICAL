using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListAlergiasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<AlergiasSelectDto>()
                {
                    new AlergiasSelectDto()
                    {
                        algi_Id = 198,
                        algi_Descripcion =    "En realidad, las alergias a las mascotas no son una reacción al pelo de su mascota, sino a las proteínas de las células cutáneas del animal."
                    },
                    new AlergiasSelectDto()
                    {
                        algi_Id = 92,
                        algi_Descripcion =    "Las alergias cutáneas son una reacción alérgica que causa una inflamación cutánea que provoca una erupción abultada y que pica en la piel."
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateAlergiasExamples : IExamplesProvider<AlergiasCreateDto>
    {
        public AlergiasCreateDto GetExamples()
        {
            return new AlergiasCreateDto()
            {
                algi_Nombre = "Alergia estacional",
                algi_Descripcion = "Alergias causadas por alérgenos de exteriores como el polen. Estos alérgenos son muy ligeros y pueden ser transportados por el aire con facilidad.",
                algi_UsuarioRegistra = 1
            };
        }
    }

    public class CreateAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class CreateAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateAlergiasExamples : IExamplesProvider<AlergiasUpdateDto>
    {
        public AlergiasUpdateDto GetExamples()
        {
            return new AlergiasUpdateDto()
            {
                algi_Id = 929,
                algi_Nombre = "Alergias de interior",
                algi_Descripcion = "Las alergias de interior son desencadenadas por cosas como los ácaros del polvo que prosperan en entornos templados y húmedos.",
                algi_UsuarioModifica = 1
            };
        }
    }

    public class UpdateAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class UpdateAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteAlergiasExamples : IExamplesProvider<AlergiasDeleteDto>
    {
        public AlergiasDeleteDto GetExamples()
        {
            return new AlergiasDeleteDto()
            {
                algi_Id = 743
            };
        }
    }

    public class DeleteAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class DeleteAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
