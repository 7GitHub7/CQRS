using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Functions.Posts.Queries.GetPostDetail
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set;}
        public string DisplayName { get; set; }
    }
}
