using Ecommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Ecommerce.Permissions;

public class EcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcommercePermissions.GroupName);

        var examplePermission = myGroup.AddPermission(EcommercePermissions.Example.Default, L("Permission:Example"));
        examplePermission.AddChild(EcommercePermissions.Example.Create, L("Permission:Create"));
        examplePermission.AddChild(EcommercePermissions.Example.Update, L("Permission:Update"));
        examplePermission.AddChild(EcommercePermissions.Example.Delete, L("Permission:Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceResource>(name);
    }
}
