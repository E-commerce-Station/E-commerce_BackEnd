using Ecommerce.Customers;
using Ecommerce.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.Pages.Orders;

public class IndexModel : EcommercePageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid CustomerId { get; set; }
    public List<SelectListItem> Customers { get; set; }
    private readonly ICustomerAppService _customerAppService;

    public IndexModel(ICustomerAppService customerAppService)
    {
        _customerAppService = customerAppService;
    }

    public virtual async Task OnGetAsync()
    {
        Customers = new List<SelectListItem>();
        var listCustomer = await _customerAppService.GetAllCustomerAsync();

        Customers.Add(new SelectListItem
        {
            Text = L["All"],
            Value = Guid.Empty.ToString()
        });

        if (CustomerId == Guid.Empty)
        {
            Customers.AddRange(listCustomer.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList());
        }
        else
        {
            var customer = listCustomer.FirstOrDefault(x => x.Id == CustomerId);

            Customers.Add(new SelectListItem
            {
                Value = customer.Id.ToString(),
                Text = customer.Name,
                Selected = true
            });
            listCustomer.Remove(customer);
            Customers.AddRange(listCustomer.Where(x => x.Id != CustomerId).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList());
            
        }

        await Task.CompletedTask;
    }
}