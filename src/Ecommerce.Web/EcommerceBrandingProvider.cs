using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Ecommerce.Web;

[Dependency(ReplaceServices = true)]
public class EcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ecommerce";
}
