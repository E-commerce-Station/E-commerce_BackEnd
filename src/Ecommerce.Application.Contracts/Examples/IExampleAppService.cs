using Ecommerce.Examples.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Examples;

public interface IExampleAppService :
    ICrudAppService<
        ExampleDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateExampleDto,
        CreateUpdateExampleDto>
{
    Task<PagedResultDto<ExampleDto>> SearchAsync(ExampleSearchDto condition);
}