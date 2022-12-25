using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Examples;

public class IndexModel : EcommercePageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}