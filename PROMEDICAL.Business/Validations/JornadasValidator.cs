using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class JornadasCreateValidator : AbstractValidator<JornadasCreateDto>
    {
        public JornadasCreateValidator()
        {
            RuleFor(x => x.jorn_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.jorn_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class JornadasUpdateValidator : AbstractValidator<JornadasUpdateDto>
    {
        public JornadasUpdateValidator()
        {
            RuleFor(x => x.jorn_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.jorn_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.jorn_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
