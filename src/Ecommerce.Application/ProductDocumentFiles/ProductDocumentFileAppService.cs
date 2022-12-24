using Ecommerce.ProductDocumentFiles.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductDocumentFiles
{
    public class ProductDocumentFileAppService : CrudAppService<ProductDocumentFile, ProductDocumentFileDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDocumentFileDto>, IProductDocumentFileAppService
    {
        private readonly IProductDocumentFileRepository _productDocumentFileRepository;

        public ProductDocumentFileAppService(IProductDocumentFileRepository productDocumentFileRepository) : base(productDocumentFileRepository)
        {
            _productDocumentFileRepository = productDocumentFileRepository;
        }
    }
}
