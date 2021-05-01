using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryInListViewModel>>
    {
    }
}
