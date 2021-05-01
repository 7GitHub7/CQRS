using CQRS_strona.Application.Common;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Queries.GetCategoryListWithPosts
{
    public class GetCategoriesWithPostListQuery : IRequest<List<CategoryPostListViewModel>>
    {
        public SearchCategoryOptions searchCategory { get; set; }
    }
}
