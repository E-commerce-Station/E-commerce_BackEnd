using Ecommerce.DocumentFiles.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.DocumentFiles
{
    public class DocumentFileAppService : CrudAppService<DocumentFile, DocumentFileDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDocumentFileDto>, IDocumentFileAppService
    {
        private readonly IDocumentFileRepository _documentFileRepository;

        public DocumentFileAppService(IDocumentFileRepository documentFileRepository) : base(documentFileRepository)
        {
            _documentFileRepository = documentFileRepository;
        }
    }
}
