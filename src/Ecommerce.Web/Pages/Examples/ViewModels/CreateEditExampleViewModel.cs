using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Web.Pages.Examples.ViewModels;

public class CreateEditCustomerViewModel
{
    [Display(Name = "ExampleName")]
    public string Name { get; set; }

    [Display(Name = "ExampleNote")]
    public string Note { get; set; }
}