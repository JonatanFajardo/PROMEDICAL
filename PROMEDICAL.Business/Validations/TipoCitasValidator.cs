using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class TipoCitasCreateValidator : AbstractValidator<TipoCitasCreateDto>
    {
        public TipoCitasCreateValidator()
        {
            RuleFor(x => x.tici_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.tici_UsuarioRegistra).NotEmpty().NotEqual(0);
        }
    }
    public class TipoCitasUpdateValidator : AbstractValidator<TipoCitasUpdateDto>
    {
        public TipoCitasUpdateValidator()
        {
            RuleFor(x => x.tici_Id).NotEmpty().NotEqual(0);
            RuleFor(x => x.tici_Descripcion).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.tici_UsuarioModifica).NotEmpty().NotEqual(0);
        }
    }
}
