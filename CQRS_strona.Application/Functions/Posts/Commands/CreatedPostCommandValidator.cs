using CQRS_strona.Application.Contract.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Posts.Commands.CreatePost
{
    class CreatedPostCommandValidator:AbstractValidator<CreatedPostCommand>
    {
        private readonly IPostRepository _postRepository;
        public CreatedPostCommandValidator(IPostRepository postRepository)
        {
            _postRepository = postRepository;
            RuleFor(p => p.Title)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(80)
                .WithMessage("{PropertyName} must not exced 80 characters");

            RuleFor(p => p.Date)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .LessThan(DateTime.Now.AddDays(1));

            RuleFor(p => p.Rate)
                .InclusiveBetween(0, 100)
                .WithMessage("{PropertyName} is between 0 to 100");

            
        }

        private async Task<bool> IsNameAndAuthorAlreadyExist(CreatedPostCommand e, CancellationToken cancellationtoken)
        {
            var check = await _postRepository.IsNameAndAuthorAlreadyExist(e.Title, e.Author);
            return !check;
        }
    }
}
