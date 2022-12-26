using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Orders;

public class IndexModel : EcommercePageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}