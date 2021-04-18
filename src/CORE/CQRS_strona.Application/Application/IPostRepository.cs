using CQRS_strona.Domain.Entities;

using System.Threading.Tasks;
using CQRS_strona.Application.Contracts.Persistance.IAsyncRepository;

namespace  CQRS_strona.Application.Contracts.Persistance
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        
    }
}