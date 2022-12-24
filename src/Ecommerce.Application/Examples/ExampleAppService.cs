using Ecommerce.Examples.Dtos;
using Ecommerce.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Examples;

/// <summary>
/// Service example
/// <para>Author: HoangNM</para>
/// <para>Created: 20/08/2022</para>
/// </summary>
public class ExampleAppService : CrudAppService<Example, ExampleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateExampleDto, CreateUpdateExampleDto>,
    IExampleAppService
{
    protected override string GetPolicyName { get; set; } = EcommercePermissions.Example.Default;
    protected override string GetListPolicyName { get; set; } = EcommercePermissions.Example.Default;
    protected override string UpdatePolicyName { get; set; } = EcommercePermissions.Example.Update;
    protected override string DeletePolicyName { get; set; } = EcommercePermissions.Example.Delete;

    private readonly IExampleRepository _repository;

    public ExampleAppService(IExampleRepository repository) : base(repository)
    {
        _repository = repository;
    }

    public async Task<PagedResultDto<ExampleDto>> SearchAsync(ExampleSearchDto condition)
    {
        PagedResultDto<ExampleDto> listResultDto = new PagedResultDto<ExampleDto>();
        var queryable = await _repository.GetQueryableAsync();
        var result = queryable.Where(x => x.Name.Contains(condition.Keyword));
        listResultDto.TotalCount = result.Count();
        listResultDto.Items =ObjectMapper.Map<List<Example>, List<ExampleDto>>(result.Skip(condition.SkipCount).Take(condition.MaxResultCount).ToList());
        return listResultDto;
    }

    public async Task<bool> IsDeleted()
    {
        return true;
    }
}