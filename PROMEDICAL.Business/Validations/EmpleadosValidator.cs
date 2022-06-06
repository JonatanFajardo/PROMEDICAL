using FluentValidation;
using PROMEDICAL.Business.Dto;

namespace PROMEDICAL.Business.Validations
{
    public class EmpleadosCreateValidator : AbstractValidator<EmpleadosCreateDto>
    {
        public EmpleadosCreateValidator()
        {
            RuleFor(x => x.carg_Id).NotEmpty();
            RuleFor(x => x.cons_Id).NotEmpty();
            RuleFor(x => x.jorn_Id).NotEmpty();
            RuleFor(x => x.pers_Identidad).NotNull().NotEmpty().Matches("[1-9][0-9]*").MinimumLength(13).MaximumLength(13);
            RuleFor(x => x.pers_PrimerNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_SegundoNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoPaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoMaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_FechaNacimiento).NotNull().NotEmpty();
            RuleFor(x => x.pers_CorreoElectronico).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Telefono).NotNull().NotEmpty().Matches("[1-9][0-9]*").MinimumLength(8).MaximumLength(8);
            RuleFor(x => x.pers_Calle).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Ciudad).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Provincia).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_CodigoPostal).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Pais).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Sexo).NotNull().NotEmpty();
            RuleFor(x => x.pers_UsuarioRegistra).NotNull().NotEmpty();
        }
    }
    public class EmpleadosUpdateValidator : AbstractValidator<EmpleadosUpdateDto>
    {
        public EmpleadosUpdateValidator()
        {
            RuleFor(x => x.empd_Id).NotEmpty();
            RuleFor(x => x.carg_Id).NotEmpty();
            RuleFor(x => x.cons_Id).NotEmpty();
            RuleFor(x => x.jorn_Id).NotEmpty();
            RuleFor(x => x.pers_PrimerNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_SegundoNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoPaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoMaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_FechaNacimiento).NotNull().NotEmpty();
            RuleFor(x => x.pers_CorreoElectronico).NotNull().NotEmpty().Matches("");
            RuleFor(x => x.pers_Telefono).NotNull().NotEmpty().Matches("[1-9][0-9]*").MinimumLength(8).MaximumLength(8);
            RuleFor(x => x.pers_Calle).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Ciudad).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Provincia).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_CodigoPostal).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Pais).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Sexo).NotNull().NotEmpty();
            RuleFor(x => x.pers_UsuarioModifica).NotNull().NotEmpty();
        }
    }

}
