using AutoMapper;
using Ecommerce.Examples.Dtos;
using Ecommerce.Web.Pages.Examples.ViewModels;
using Ecommerce.Web.Pages.Category.ViewModels;
using Ecommerce.Categories.Dtos;

namespace Ecommerce.Web;

public class EcommerceWebAutoMapperProfile : Profile
{
    public EcommerceWebAutoMapperProfile()
    {
        // Example
        CreateMap<ExampleDto, CreateEditExampleViewModel>();
        CreateMap<CreateEditExampleViewModel, CreateUpdateExampleDto>();

        // Category
        CreateMap<CategoryDto, CreateEditCategoryViewModel>();
        CreateMap<CreateEditCategoryViewModel, CreateUpdateCategoryDto>();

        //Define your AutoMapper configuration here for the Web project.
    }
}
