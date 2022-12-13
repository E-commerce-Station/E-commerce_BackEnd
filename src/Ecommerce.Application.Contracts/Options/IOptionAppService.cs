using Ecommerce.Options.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Options
{
    public interface IOptionAppService : ICrudAppService<OptionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOptionDto>
    {
    }
}
