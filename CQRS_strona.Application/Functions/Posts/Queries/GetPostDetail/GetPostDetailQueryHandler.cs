using AutoMapper;
using CQRS_strona.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Application.Contracts.Persistance;

namespace CQRS_strona.Application.Functions.Posts.Queries.GetPostDetail
{
    class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, PostDetailViewModel>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetPostDetailQueryHandler(IAsyncRepository<Post> postRepository, IAsyncRepository<Category> categoryRepository,IMapper mapper)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<PostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.Id);
            var postdetail = _mapper.Map<PostDetailViewModel>(post);

            var category = await _categoryRepository.GetByIdAsync(post.CategoryId);

            postdetail.Category = _mapper.Map<CategoryDto>(category);
            
            return postdetail;
        }
    }
}
