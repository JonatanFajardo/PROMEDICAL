using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class CitasCreateValidator : AbstractValidator<Citas_CreateDto>
    {
        public CitasCreateValidator()
        {
            RuleFor(x => x.paci_Id).NotEmpty();
            RuleFor(x => x.empd_Id).NotEmpty();
            RuleFor(x => x.tici_Id).NotEmpty();
            RuleFor(x => x.cita_FechaCita).NotNull().NotEmpty();
            RuleFor(x => x.pers_UsuarioRegistra).NotEmpty();
        }
    }

}
