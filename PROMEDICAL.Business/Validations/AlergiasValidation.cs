using FluentValidation;
using PROMEDICAL.Business.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Validations
{
    public class AlergiasValidation : AbstractValidator<AlergiasDto>
    {
        public AlergiasValidation()
        {
            RuleFor(x=> x.algi_Descripcion).NotEmpty().WithMessage("Porfaaa");

        }
    }
}
