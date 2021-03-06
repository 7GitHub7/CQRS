using CQRS_strona.Application;
using CQRS_strona.Application.Common;
using CQRS_strona.Application.Functions.Categories.Commands;
using CQRS_strona.Application.Functions.Categories.Commands.CreateCategory;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryListWithPosts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_strona.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryInListViewModel>>> GetAllCategories()
        {
            var categoryInListViewModel = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(categoryInListViewModel);
        }

        [HttpGet("allwithposts", Name = "GetCategoriesWithPosts")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryPostListViewModel>>> GetCategoriesWithPosts
            (SearchCategoryOptions searchOptions)
        {
            GetCategoriesWithPostListQuery getCategoriesListWithPostsQuery =
                new GetCategoriesWithPostListQuery() { searchCategory = searchOptions };

            var dtos = await _mediator.Send(getCategoriesListWithPostsQuery);
            return Ok(dtos);
        }

        [HttpPost(Name = "addCategory")]
        public async Task<ActionResult<CreatedCategoryCommandResponse>> Create
            ([FromBody] CreatedCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
