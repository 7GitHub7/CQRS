using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}