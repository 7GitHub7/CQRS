using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Posts.Commands.CreatePost
{
    class ValidationCQRSException : SystemException
    {
        public List<string> ErrorMessage { get; set; }

        public ValidationCQRSException(ValidationResult validationResult)
        {
            ErrorMessage = new List<string>();

            foreach (var item in validationResult.Errors)
            {
                ErrorMessage.Add(item.ErrorMessage);
            }
        }
    }
}
