using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Examples.Dtos;

[Serializable]
public class ExampleDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Note { get; set; }
}