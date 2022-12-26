using Ecommerce.Categories;
using Ecommerce.Categories.Dtos;
using Ecommerce.Web.Pages.Category.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Category;

public class EditModalModel : EcommercePageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditCategoryViewModel ViewModel { get; set; }

    private readonly ICategoryAppService _service;

    public EditModalModel(ICategoryAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<CategoryDto, CreateEditCategoryViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCategoryViewModel, CreateUpdateCategoryDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}