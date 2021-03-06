using CQRS_strona.Application.Common;
using CQRS_strona.Application.Contracts.Persistance;
using CQRS_strona.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_strona.Persistence.EF.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CQRS_stronaContext dbContext) : base(dbContext)
        { }

        public async Task<List<Category>> GetCategoriesWithPost(SearchCategoryOptions searchCategory)
        {
            var allCategories = await _dbContext.Categories.Include(p => p.Posts).ToListAsync();

            if (searchCategory == SearchCategoryOptions.FirstBestInAllTheTime)
            {

                foreach (var c in allCategories)
                {
                    Post max = null;
                    foreach (var p in c.Posts)
                    {
                        if (max == null)
                        {
                            max = p;
                            break;
                        }

                        if (max.Rate < p.Rate)
                            max = p;

                    }
                    c.Posts = new List<Post>();
                    if (max != null)
                        c.Posts.Add(max);
                }

                return allCategories;
            }
            else if (searchCategory == SearchCategoryOptions.FirstBestInMonth)
            {
                DateTime d = DateTime.Now;

                allCategories = allCategories.Where(c =>
                c.Posts.Any(p => (p.Date.Month == d.Month && d.Year == p.Date.Year)))
                    .ToList();

                foreach (var c in allCategories)
                {
                    Post max = null;
                    foreach (var p in c.Posts)
                    {
                        if (max == null)
                        {
                            max = p;
                            break;
                        }

                        if (max.Rate < p.Rate)
                            max = p;

                    }
                    c.Posts = new List<Post>();
                    if (max != null)
                        c.Posts.Add(max);
                }

                return allCategories;
            }


            return allCategories;
        }
    }
}
