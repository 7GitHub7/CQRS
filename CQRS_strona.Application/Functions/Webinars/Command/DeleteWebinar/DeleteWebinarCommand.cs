using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Webinars.Command.DeleteWebinar
{
    public class DeleteWebinarCommand : IRequest
    {
        public int WebinarId { get; set; }
    }
}
