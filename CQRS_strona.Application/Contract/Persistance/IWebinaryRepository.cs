using CQRS_strona.Application.Common;
using CQRS_strona.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_strona.Application.Contract.Persistance
{
    public interface IWebinaryRepository : IAsyncRepository<Webinar>
    {
        Task<int> GetTotalCountOfWebinarsForDate(SearchOptionsWebinars oprions, DateTime? date);

        Task<List<Webinar>> GetPagedWebinarsForDate(SearchOptionsWebinars options, int page, int pageSize, DateTime? date);
    }
}
