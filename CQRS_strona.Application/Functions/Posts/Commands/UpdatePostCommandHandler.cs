
using AutoMapper;
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler
        : IRequestHandler<UpdatePostCommand>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public async Task<Unit> Handle(UpdatePostCommand request,
            CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);

            await _postRepository.UpdateAsync(post);

            return Unit.Value;
        }

        public UpdatePostCommandHandler(IPostRepository postRepository,
            IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
    }
}