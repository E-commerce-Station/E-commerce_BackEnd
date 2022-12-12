namespace Ecommerce.Permissions;

public static class EcommercePermissions
{
    public const string GroupName = "Ecommerce";

    public class Example
    {
        public const string Default = GroupName + ".Example";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
