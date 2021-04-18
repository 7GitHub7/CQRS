using CQRS_strona.Domain.Entities;


namespace CQRS_strona.Application.Contracts.Persistance
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {

        //Task<List<Category>>
        //GetCategoriesWithPost(SearchCategoryOptions searchCategory);
    }
}