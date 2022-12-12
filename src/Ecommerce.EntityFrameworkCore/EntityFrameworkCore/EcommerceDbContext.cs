using Ecommerce.Examples;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Ecommerce.Customers;
using Ecommerce.Products;
using Ecommerce.Categories;
using Ecommerce.Options;
using Ecommerce.ProductCategories;
using Ecommerce.ProductOptions;
using Ecommerce.DocumentFiles;
using Ecommerce.ProductDocumentFiles;
using Ecommerce.Orders;
using Ecommerce.OrderDetails;

namespace Ecommerce.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class EcommerceDbContext :
    AbpDbContext<EcommerceDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
    public DbSet<Example> Examples { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Option> Options { get; set; }

    public DbSet<ProductCategory> ProductCategories { get; set; }

    public DbSet<ProductOption> ProductOptions { get; set; }

    public DbSet<DocumentFile> DocumentFiles { get; set; }

    public DbSet<ProductDocumentFile> ProductDocumentFiles { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(EcommerceConsts.DbTablePrefix + "YourEntities", EcommerceConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<Example>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Examples", EcommerceConsts.DbSchema);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<Customer>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Customers", EcommerceConsts.DbSchema);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<Product>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Products", EcommerceConsts.DbSchema);
            b.HasOne(x => x.ProductCategory).WithMany(x => x.Products).HasForeignKey(x => x.ProductCategoryId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<Category>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Categories", EcommerceConsts.DbSchema);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<Option>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Options", EcommerceConsts.DbSchema);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<ProductCategory>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "ProductCategoríe", EcommerceConsts.DbSchema);
            b.HasOne(x => x.Category).WithMany(x => x.ProductCategories).HasForeignKey(x => x.CategoryId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<ProductOption>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "ProductOptions", EcommerceConsts.DbSchema);
            b.HasOne(x => x.Option).WithMany(x => x.ProductOptions).HasForeignKey(x => x.OptionId);
            b.HasOne(x => x.Product).WithMany(x => x.ProductOptions).HasForeignKey(x => x.ProductId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<DocumentFile>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "DocumentFiles", EcommerceConsts.DbSchema);
            b.HasOne(x => x.ProductDocumentFile).WithMany(x => x.DocumentFiles).HasForeignKey(x => x.ProductDocumentFileId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<ProductDocumentFile>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "ProductDocumentFiles", EcommerceConsts.DbSchema);
            b.HasOne(x => x.Product).WithMany(x => x.ProductDocumentFiles).HasForeignKey(x => x.ProductId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<Order>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "Orders", EcommerceConsts.DbSchema);
            b.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });

        builder.Entity<OrderDetail>(b =>
        {
            b.ToTable(EcommerceConsts.DbTablePrefix + "OrderDetails", EcommerceConsts.DbSchema);
            b.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            b.ConfigureByConvention();

            /* Configure more properties here */
        });
    }
}
