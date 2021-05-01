using CQRS_strona.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Commands
{
    public class CreatedCategoryCommandResponse : BaseResponse
    {
        public int? CategoryId { get; set; }

        public CreatedCategoryCommandResponse() : base() { }
        public CreatedCategoryCommandResponse(ValidationResult validationResult) : base(validationResult) { }
        public CreatedCategoryCommandResponse(string message) : base(message) { }
        public CreatedCategoryCommandResponse(string message,bool success) : base(message,success) { }
        public CreatedCategoryCommandResponse(int categoryID)  
        {
            CategoryId = categoryID;
        }


    }
}
