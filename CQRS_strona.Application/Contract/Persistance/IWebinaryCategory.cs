using CQRS_strona.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Contract.Persistance
{
    public interface IWebinaryCategory : IAsyncRepository<Webinars>
    {
    }
}
