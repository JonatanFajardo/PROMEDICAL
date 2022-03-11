using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class TipoConsultasCreateValidator : AbstractValidator<TipoConsultas_CreateDto>
    {
        public TipoConsultasCreateValidator()
        {
            RuleFor(x => x.tico_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.tico_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class TipoConsultasUpdateValidator : AbstractValidator<TipoConsultas_UpdateDto>
    {
        public TipoConsultasUpdateValidator()
        {
            RuleFor(x => x.tico_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.tico_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.tico_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
