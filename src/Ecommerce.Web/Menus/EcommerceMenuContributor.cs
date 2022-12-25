using System.Threading.Tasks;
using Ecommerce.Localization;
using Ecommerce.MultiTenancy;
using Ecommerce.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Ecommerce.Web.Menus;

public class EcommerceMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<EcommerceResource>();

        if(await context.IsGrantedAsync(EcommercePermissions.Example.Default))
        {
            context.Menu.Items.Insert(1,
                new ApplicationMenuItem(EcommerceMenus.Example, l["Menu:Example"], "/Examples", icon: "fa fa-flag", order: 1)
               );
        }

        if(await context.IsGrantedAsync(EcommercePermissions.Product.Default))
        {
            context.Menu.Items.Insert(1,
                new ApplicationMenuItem(EcommerceMenus.Product, l["Menu:Product"], "/Products", icon: "fa fa-mobile", order: 1)
                );
        }

        if(await context.IsGrantedAsync(EcommercePermissions.Category.Default))
        {
            context.Menu.Items.Insert(1,
                new ApplicationMenuItem(EcommerceMenus.Category, l["Menu:Category"], "/Categories", icon: "fa fa-window-restore", order: 1)
                );
        }

        if(await context.IsGrantedAsync(EcommercePermissions.Customer.Default))
        {
            context.Menu.Items.Insert(1,
                new ApplicationMenuItem(EcommerceMenus.Customer, l["Menu:Customer"], "/Customers", icon: "fa fa-user-o", order: 1)
                );
        }

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                EcommerceMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
