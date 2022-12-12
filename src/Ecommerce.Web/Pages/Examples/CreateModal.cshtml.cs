using Ecommerce.Examples;
using Ecommerce.Examples.Dtos;
using Ecommerce.Web.Pages.Examples.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Examples;

public class CreateModalModel : EcommercePageModel
{
    [BindProperty]
    public CreateEditExampleViewModel ViewModel { get; set; }

    private readonly IExampleAppService _service;

    public CreateModalModel(IExampleAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditExampleViewModel, CreateUpdateExampleDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}