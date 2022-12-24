using Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ecommerce.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EcommercePageModel : AbpPageModel
{
    protected EcommercePageModel()
    {
        LocalizationResourceType = typeof(EcommerceResource);
    }
}
