using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class ConsultoriosCreateValidator : AbstractValidator<ConsultoriosCreateDto>
    {
        public ConsultoriosCreateValidator()
        {
            RuleFor(x => x.cons_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.cons_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class ConsultoriosUpdateValidator : AbstractValidator<ConsultoriosUpdateDto>
    {
        public ConsultoriosUpdateValidator()
        {
            RuleFor(x => x.cons_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.cons_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.cons_UsuarioModifica).NotEmpty().NotEqual(0);

        }
    }
}
