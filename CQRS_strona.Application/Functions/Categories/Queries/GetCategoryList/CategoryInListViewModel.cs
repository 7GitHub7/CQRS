using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList
{
    public class CategoryInListViewModel
    {
        public int CategotyId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
