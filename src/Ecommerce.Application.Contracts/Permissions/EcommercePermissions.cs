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

    public class Product
    {
        public const string Default = GroupName + ".Product";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class Customer
    {
        public const string Default = GroupName + ".Customer";
    }

    public class Category
    {
        public const string Default = GroupName + ".Category";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class DocumentFile
    {
        public const string Default = GroupName + ".DocumentFile";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class Order
    {
        public const string Default = GroupName + ".Order";
    }

    public class Option
    {
        public const string Default = GroupName + ".Option";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
