using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class ConsultoriosCreateValidator : AbstractValidator<Consultorios_CreateDto>
    {
        public ConsultoriosCreateValidator()
        {
            RuleFor(x => x.cons_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.cons_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class ConsultoriosUpdateValidator : AbstractValidator<Consultorios_UpdateDto>
    {
        public ConsultoriosUpdateValidator()
        {
            RuleFor(x => x.cons_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.cons_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.cons_UsuarioModifica).NotEmpty().NotEqual(0);

        }
    }
}
