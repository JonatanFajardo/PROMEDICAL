using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class CargosCreateValidator : AbstractValidator<CargosCreateDto>
    {
        public CargosCreateValidator()
        {
            RuleFor(x => x.carg_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.carg_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class CargosUpdateValidator : AbstractValidator<CargosUpdateDto>
    {
        public CargosUpdateValidator()
        {
            RuleFor(x => x.carg_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.carg_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.carg_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
