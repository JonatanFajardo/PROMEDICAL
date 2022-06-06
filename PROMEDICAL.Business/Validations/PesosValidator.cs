using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class PesosCreateValidator : AbstractValidator<PesosCreateDto>
    {
        public PesosCreateValidator()
        {
            RuleFor(x => x.peso_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.paci_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.peso_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class PesosUpdateValidator : AbstractValidator<PesosUpdateDto>
    {
        public PesosUpdateValidator()
        {
            RuleFor(x => x.peso_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.paci_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.peso_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.peso_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
