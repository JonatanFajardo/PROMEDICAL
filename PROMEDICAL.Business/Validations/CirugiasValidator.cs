using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class CirugiasCreateValidator : AbstractValidator<CirugiasCreateDto>
    {
        public CirugiasCreateValidator()
        {
            RuleFor(x => x.ciru_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.ciru_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class CirugiasUpdateValidator : AbstractValidator<CirugiasUpdateDto>
    {
        public CirugiasUpdateValidator()
        {
            RuleFor(x => x.ciru_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.ciru_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.ciru_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
