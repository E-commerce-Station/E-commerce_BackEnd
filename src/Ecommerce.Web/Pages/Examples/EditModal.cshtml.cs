using Ecommerce.Examples;
using Ecommerce.Examples.Dtos;
using Ecommerce.Web.Pages.Examples.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Examples;

public class EditModalModel : EcommercePageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditCustomerViewModel ViewModel { get; set; }

    private readonly IExampleAppService _service;

    public EditModalModel(IExampleAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<ExampleDto, CreateEditCustomerViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateExampleDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}