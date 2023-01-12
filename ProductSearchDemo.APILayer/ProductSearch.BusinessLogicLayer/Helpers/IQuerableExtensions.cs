using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearch.BusinessLogicLayer.Helpers
{
    public static class IQuerableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> querable, int recordsPerPage, int Page )
        {
            return querable.Skip( (Page-1) * recordsPerPage ).Take(recordsPerPage);
        }
    }
}
