using CQRS_strona.Application.Common;
using CQRS_strona.Application.Functions.Webinars.Queries.GetWebinarListByDate;
using MediatR;
using System;
using System.IO;
using System.Text;

namespace CQRS_strona.Application.Functions.Webinars.Queries
{
    public class GetWebinarsByDateQuery:IRequest<PageWebinarByDateViewModel>
    {
        public DateTime? Date { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public SearchOptionsWebinars Options{ get; set; }
    }
}
