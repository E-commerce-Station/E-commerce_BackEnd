using Ecommerce.Options.Dtos;
using Ecommerce.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Options
{
    public class OptionAppService : CrudAppService<Option, OptionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOptionDto>, IOptionAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.Option.Default;
        protected override string GetListPolicyName { get; set; } = EcommercePermissions.Option.Default;
        protected override string UpdatePolicyName { get; set; } = EcommercePermissions.Option.Update;
        protected override string DeletePolicyName { get; set; } = EcommercePermissions.Option.Delete;
        private readonly IOptionRepository _optionRepository;

        public OptionAppService(IOptionRepository optionRepository) : base(optionRepository)
        {
            _optionRepository = optionRepository;
        }
    }
}
