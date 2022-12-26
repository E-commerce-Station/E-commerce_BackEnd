using AutoMapper;
using Ecommerce.Examples.Dtos;
using Ecommerce.Examples;
using Ecommerce.Categories;
using Ecommerce.Categories.Dtos;
using Ecommerce.Customers;
using Ecommerce.Customers.Dtos;
using Ecommerce.DocumentFiles;
using Ecommerce.DocumentFiles.Dtos;
using Ecommerce.Options;
using Ecommerce.Options.Dtos;
using Ecommerce.OrderDetails;
using Ecommerce.OrderDetails.Dtos;
using Ecommerce.Orders;
using Ecommerce.Orders.Dtos;
using Ecommerce.ProductCategories;
using Ecommerce.ProductCategories.Dtos;
using Ecommerce.ProductOptions;
using Ecommerce.ProductOptions.Dtos;
using Ecommerce.Products;
using Ecommerce.Products.Dtos;
using Ecommerce.ProductDocumentFiles;
using Ecommerce.ProductDocumentFiles.Dtos;

namespace Ecommerce;

public class EcommerceApplicationAutoMapperProfile : Profile
{
    public EcommerceApplicationAutoMapperProfile()
    {
        // Example
        CreateMap<Example, ExampleDto>();
        CreateMap<CreateUpdateExampleDto, Example>(MemberList.Source);

        // Category
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();

        // Customer
        CreateMap<Customer, CustomerDto>();
        CreateMap<CreateUpdateCustomerDto, Customer>();

        // DocumentFile
        CreateMap<DocumentFile, DocumentFileDto>();
        CreateMap<CreateUpdateDocumentFileDto, DocumentFile>();

        // Option
        CreateMap<Option, OptionDto>();
        CreateMap<CreateUpdateOptionDto, Option>();

        // OrderDetail
        CreateMap<OrderDetail, OrderDetailDto>();
        CreateMap<CreateUpdateOrderDetailDto, OrderDetail>();

        // Order
        CreateMap<Order, OrderDto>().ForMember(x => x.CustomerName, y => y.MapFrom(u => u.Customer.Name));
        CreateMap<CreateUpdateOrderDto, Order>();

        // ProductCategory
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        // ProductOption
        CreateMap<ProductOption, ProductOptionDto>();
        CreateMap<CreateUpdateProductOptionDto, ProductOption>();

        // Product
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        // ProductDocumentFile
        CreateMap<ProductDocumentFile, ProductDocumentFileDto>();
        CreateMap<CreateUpdateProductDocumentFileDto, ProductDocumentFile>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
