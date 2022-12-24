using Ecommerce.Options.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Options
{
    public class OptionAppService : CrudAppService<Option, OptionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOptionDto>, IOptionAppService
    {
        private readonly IOptionRepository _optionRepository;

        public OptionAppService(IOptionRepository optionRepository) : base(optionRepository)
        {
            _optionRepository = optionRepository;
        }
    }
}
