using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class AlergiasCreateValidator : AbstractValidator<AlergiasCreateDto>
    {
        public AlergiasCreateValidator()
        {
            RuleFor(x => x.algi_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.algi_Nombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.algi_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class AlergiasUpdateValidator : AbstractValidator<AlergiasUpdateDto>
    {
        public AlergiasUpdateValidator()
        {
            RuleFor(x => x.algi_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.algi_Nombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.algi_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.algi_UsuarioModifica).NotEmpty().NotEqual(0);

        }
    }
}
