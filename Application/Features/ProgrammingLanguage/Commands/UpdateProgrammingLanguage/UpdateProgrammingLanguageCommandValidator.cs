using Application.Features.ProgrammingLanguage.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage;

public class UpdateProgrammingLanguageCommandValidator : AbstractValidator<UpdatedProgrammingLanguageDto>
{
    public UpdateProgrammingLanguageCommandValidator()
    {
        RuleFor(f => f.Name).NotNull();
        RuleFor(f => f.Name).NotEmpty();
    }
}
