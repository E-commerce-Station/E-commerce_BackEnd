using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Customers;

public class IndexModel : EcommercePageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}