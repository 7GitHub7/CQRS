using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery:IRequest<PostDetailViewModel>
    {
        public int Id { get; set; }
    }
}
