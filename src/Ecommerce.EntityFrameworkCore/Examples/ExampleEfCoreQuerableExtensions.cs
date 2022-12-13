using System.Linq;

namespace Ecommerce.Examples;

public static class ExampleEfCoreQueryableExtensions
{
    public static IQueryable<Example> IncludeDetails(this IQueryable<Example> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}