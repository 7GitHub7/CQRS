using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_strona.Application.Common
{
   public enum SearchCategoryOptions
    {
        All = 0,
        FirstBestInMonth = 2,
        FirstBestInAllTheTime = 3,
    }
}
