using CQRS_strona.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Contracts.Persistance
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>>
            GetCategoriesWithPost(SearchCategoryOptions searchCategory);
    }
}