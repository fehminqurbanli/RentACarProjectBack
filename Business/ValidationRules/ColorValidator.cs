﻿using Enitites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
