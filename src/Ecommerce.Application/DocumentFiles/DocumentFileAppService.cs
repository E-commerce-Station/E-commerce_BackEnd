using Ecommerce.DocumentFiles.Dtos;
using Ecommerce.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.DocumentFiles
{
    public class DocumentFileAppService : CrudAppService<DocumentFile, DocumentFileDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDocumentFileDto>, IDocumentFileAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.DocumentFile.Default;
        protected override string GetListPolicyName { get; set; } = EcommercePermissions.DocumentFile.Default;
        protected override string UpdatePolicyName { get; set; } = EcommercePermissions.DocumentFile.Update;
        protected override string DeletePolicyName { get; set; } = EcommercePermissions.DocumentFile.Delete;
        private readonly IDocumentFileRepository _documentFileRepository;

        public DocumentFileAppService(IDocumentFileRepository documentFileRepository) : base(documentFileRepository)
        {
            _documentFileRepository = documentFileRepository;
        }
    }
}
