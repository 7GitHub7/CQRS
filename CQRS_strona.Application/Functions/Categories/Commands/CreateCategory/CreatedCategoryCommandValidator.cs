using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Commands.CreateCategory
{
    class CreatedCategoryCommandValidator: AbstractValidator<CreatedCategoryCommand>
    {
        public CreatedCategoryCommandValidator()
        {
            RuleFor(c => c.Name).
                MinimumLength(2).MaximumLength(15)
                .WithMessage("{PropertyName} Length is beetwen 2 and 15");
            RuleFor(c => c.DisplayName).
                MinimumLength(2).MaximumLength(15)
                .WithMessage("{PropertyName} Length is beetwen 2 and 15");
        }
    }
}
