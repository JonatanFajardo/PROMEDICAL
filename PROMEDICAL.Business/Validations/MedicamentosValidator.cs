using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class MedicamentosCreateValidator : AbstractValidator<Medicamentos_CreateDto>
    {
        public MedicamentosCreateValidator()
        {
            RuleFor(x => x.medi_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.medi_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class MedicamentosUpdateValidator : AbstractValidator<Medicamentos_UpdateDto>
    {
        public MedicamentosUpdateValidator()
        {
            RuleFor(x => x.medi_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.medi_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.medi_UsuarioModifica).NotEmpty().NotEqual(0);

        }
    }
}
