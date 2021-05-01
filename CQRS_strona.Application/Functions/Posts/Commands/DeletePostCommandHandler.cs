using AutoMapper;
using CQRS_strona.Application.Contract.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Functions.Posts.Commands
{
    class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var posttodelete = await _postRepository.GetByIdAsync(request.PostId);
            await _postRepository.DeleteAsync(posttodelete);
            return Unit.Value;
        }
    }
}
