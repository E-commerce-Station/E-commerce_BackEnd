using Ecommerce.Categories;
using Ecommerce.Categories.Dtos;
using Ecommerce.Web.Pages.Category.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Category;

public class CreateModalModel : EcommercePageModel
{
    [BindProperty]
    public CreateEditCategoryViewModel ViewModel { get; set; }

    private readonly ICategoryAppService _service;

    public CreateModalModel(ICategoryAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCategoryViewModel, CreateUpdateCategoryDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}