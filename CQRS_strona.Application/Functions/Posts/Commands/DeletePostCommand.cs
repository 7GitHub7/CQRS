using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Posts.Commands
{
    public class DeletePostCommand:IRequest
    {
        public int PostId { get; set; }
    }
}
