using AutoMapper;
using Ecommerce.Examples.Dtos;
using Ecommerce.Web.Pages.Examples.ViewModels;

namespace Ecommerce.Web;

public class EcommerceWebAutoMapperProfile : Profile
{
    public EcommerceWebAutoMapperProfile()
    {
        CreateMap<ExampleDto, CreateEditExampleViewModel>();
        CreateMap<CreateEditExampleViewModel, CreateUpdateExampleDto>();
        //Define your AutoMapper configuration here for the Web project.
    }
}
