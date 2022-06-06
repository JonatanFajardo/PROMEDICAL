using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class PrescripcionesCreateValidator : AbstractValidator<PrescripcionesCreateDto>
    {
        public PrescripcionesCreateValidator()
        {
            RuleFor(x => x.pres_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pres_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class PrescripcionesUpdateValidator : AbstractValidator<PrescripcionesUpdateDto>
    {
        public PrescripcionesUpdateValidator()
        {
            RuleFor(x => x.pres_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.pres_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pres_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
