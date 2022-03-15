using FluentValidation;
using PROMEDICAL.Business.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Validations
{
    public class PacienteCreateValidator : AbstractValidator<Pacientes_CreateDto>
    {
        public PacienteCreateValidator()
        {
            RuleFor(x => x.emps_Id).NotEmpty();
            RuleFor(x => x.tipsan_Id).NotEmpty();
            RuleFor(x => x.peci_altura).NotEmpty();
            RuleFor(x => x.peci_peso).NotEmpty();
            RuleFor(x => x.pers_Identidad).NotNull().NotEmpty().Matches("[1-9][0-9]*").MaximumLength(13);
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
    public class PacientesUpdateValidator : AbstractValidator<Pacientes_UpdateDto>
    {
        public PacientesUpdateValidator()
        {
            RuleFor(x => x.paci_Id).NotEmpty();
            RuleFor(x => x.emps_Id).NotEmpty();
            RuleFor(x => x.tipsan_Id).NotEmpty();
            RuleFor(x => x.peci_altura).NotEmpty();
            RuleFor(x => x.peci_peso).NotEmpty();
            RuleFor(x => x.pers_PrimerNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_SegundoNombre).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoPaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_ApellidoMaterno).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_FechaNacimiento).NotNull().NotEmpty();
            RuleFor(x => x.pers_CorreoElectronico).NotNull().NotEmpty().Matches("[a-zA-Z]");
            RuleFor(x => x.pers_Telefono).NotNull().NotEmpty().Matches("[a-zA-Z]").MaximumLength(8);
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
