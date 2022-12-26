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

        var customerPermission = myGroup.AddPermission(EcommercePermissions.Customer.Default, L("Permission:Customer"));

        var productPermission = myGroup.AddPermission(EcommercePermissions.Product.Default, L("Permission:Product"));
        productPermission.AddChild(EcommercePermissions.Product.Create, L("Permission:Create"));
        productPermission.AddChild(EcommercePermissions.Product.Update, L("Permission:Update"));
        productPermission.AddChild(EcommercePermissions.Product.Delete, L("Permission:Delete"));

        var categoryPermission = myGroup.AddPermission(EcommercePermissions.Category.Default, L("Permission:Category"));
        categoryPermission.AddChild(EcommercePermissions.Category.Create, L("Permission:Create"));
        categoryPermission.AddChild(EcommercePermissions.Category.Update, L("Permission:Update"));
        categoryPermission.AddChild(EcommercePermissions.Category.Delete, L("Permission:Delete"));

        var documentFilePermission = myGroup.AddPermission(EcommercePermissions.DocumentFile.Default, L("Permission:DocumentFile"));
        documentFilePermission.AddChild(EcommercePermissions.DocumentFile.Create, L("Permission:Create"));
        documentFilePermission.AddChild(EcommercePermissions.DocumentFile.Update, L("Permission:Update"));
        documentFilePermission.AddChild(EcommercePermissions.DocumentFile.Delete, L("Permission:Delete"));

        var orderPermission = myGroup.AddPermission(EcommercePermissions.Order.Default, L("Permission:Order"));
        orderPermission.AddChild(EcommercePermissions.Order.UpdateStatus, L("Permission:UpdateStatus"));

        var optionPermission = myGroup.AddPermission(EcommercePermissions.Option.Default, L("Permission:Option"));
        optionPermission.AddChild(EcommercePermissions.Option.Create, L("Permission:Create"));
        optionPermission.AddChild(EcommercePermissions.Option.Update, L("Permission:Update"));
        optionPermission.AddChild(EcommercePermissions.Option.Delete, L("Permission:Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceResource>(name);
    }
}
