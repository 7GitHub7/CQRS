
using CQRS_strona.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Contract.Persistance
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<bool> IsNameAndAuthorAlreadyExist(string title, string author);
    }

   
}
