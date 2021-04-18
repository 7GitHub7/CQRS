using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Domain.Entities
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}