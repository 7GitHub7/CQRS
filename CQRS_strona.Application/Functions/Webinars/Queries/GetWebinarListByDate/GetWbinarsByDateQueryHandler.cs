using AutoMapper;
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Application.Functions.Webinars.Queries.GetWebinarListByDate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace CQRS_strona.Application.Functions.Webinars.Queries
{
    class GetWbinarsByDateQueryHandler:IRequestHandler<GetWebinarsByDateQuery,PageWebinarByDateViewModel>
    {
        private readonly IWebinaryRepository _webinaryRepository;
        private readonly IMapper _mapper;

        public GetWbinarsByDateQueryHandler(IWebinaryRepository webinarRepository,IMapper mapper)
        {
            _webinaryRepository = webinarRepository;
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<PageWebinarByDateViewModel> Handle(GetWebinarsByDateQuery request, CancellationToken cancellationToken)
        {
            var list = await _webinaryRepository.GetPagedWebinarsForDate(request.Options, request.Page, request.PageSize, request.Date);
            var webinars = _mapper.Map<List<WebinarsByDateViewModel>>(list);

            var count = await _webinaryRepository.GetTotalCountOfWebinarsForDate(request.Options, request.Date);
            return new PageWebinarByDateViewModel()
            {
                AllCount = count,
                Webinars = webinars,
                Page = request.Page,
                PageSize = request.PageSize,
            };
        }
    }
}
