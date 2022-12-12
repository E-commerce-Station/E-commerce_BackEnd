using Ecommerce.DocumentFiles.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.DocumentFiles
{
    public interface IDocumentFileAppService : ICrudAppService<DocumentFileDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDocumentFileDto>
    {
    }
}
