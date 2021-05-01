
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Domain.Entities;
using CQRS_strona.Persistence.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_strona.Persistence.EF.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(CQRS_stronaContext dbContext) : base(dbContext)
        { }

        public Task<bool> IsNameAndAuthorAlreadyExist(string title, string author)
        {
            var matches = _dbContext.Posts.
                Any(a => a.Title.Equals(title) && a.Author.Equals(author));

            return Task.FromResult(matches);
        }
    }
}
