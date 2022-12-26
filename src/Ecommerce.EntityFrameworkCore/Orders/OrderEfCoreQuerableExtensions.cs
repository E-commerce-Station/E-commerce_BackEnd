using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Orders
{
    public static class OrderEfCoreQuerableExtensions
    {
        public static IQueryable<Order> IncludeDetails(this IQueryable<Order> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable.Include(x => x.Customer)
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}
