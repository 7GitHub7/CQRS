using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Commands
{
    public class CreatedCategoryCommand : IRequest<CreatedCategoryCommandResponse>
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
