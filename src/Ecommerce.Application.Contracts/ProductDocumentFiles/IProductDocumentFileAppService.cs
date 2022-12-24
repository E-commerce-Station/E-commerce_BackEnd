using Ecommerce.ProductDocumentFiles.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductDocumentFiles
{
    public interface IProductDocumentFileAppService : ICrudAppService<ProductDocumentFileDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDocumentFileDto>
    {
    }
}
