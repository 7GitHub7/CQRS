using AutoMapper;
using CQRS_strona.Application.Contracts.Persistance;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryListWithPosts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Categories.Queries.GetCategoryListWithPosts
{
    public class GetCategoriesWithPostListQueryHandler :
        IRequestHandler<GetCategoriesWithPostListQuery, List<CategoryPostListViewModel>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesWithPostListQueryHandler(IMapper mapper,
            ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryPostListViewModel>>
            Handle(GetCategoriesWithPostListQuery request,
            CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.
                GetCategoriesWithPost(request.searchCategory);

            return _mapper.Map<List<CategoryPostListViewModel>>(list);
        }
    }


}