using CQRS_strona.Application.Functions.Posts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Get
{
    public class GetPostsListQuery: IRequest<List<PostInListViewModel>>
    {
    }
}
