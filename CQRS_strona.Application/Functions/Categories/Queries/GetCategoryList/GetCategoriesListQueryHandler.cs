using AutoMapper;
using CQRS_strona.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQueryHandler :
        IRequestHandler<GetCategoriesListQuery, List<CategoryInListViewModel>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepsitory)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepsitory;
        }

        public async Task<List<CategoryInListViewModel>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var all = await _categoryRepository.GetAllAsync();
            var ordered = all.OrderBy(a => a.Name);

            return _mapper.Map<List<CategoryInListViewModel>>(ordered);
        }
    }
}