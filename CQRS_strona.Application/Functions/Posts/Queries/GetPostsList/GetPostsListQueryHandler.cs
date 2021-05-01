using AutoMapper;
using CQRS_strona.Domain.Entities;
using Get;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Posts.Queries.GetPostsList
{
    
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<PostInListViewModel>>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IMapper mapper, IAsyncRepository<Post> postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<List<PostInListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var all = await _postRepository.GetAllAsync();
            var allordered = all.OrderBy(x => x.Date);

            return _mapper.Map<List<PostInListViewModel>>(all);
        }
    }
}
