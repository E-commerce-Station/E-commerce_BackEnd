using Ecommerce.Categories.Dtos;
using Ecommerce.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Categories
{
    public class CategoryAppService : CrudAppService<Category, CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>, ICategoryAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.Category.Default;
        protected override string GetListPolicyName { get; set; } = EcommercePermissions.Category.Default;
        protected override string UpdatePolicyName { get; set; } = EcommercePermissions.Category.Update;
        protected override string DeletePolicyName { get; set; } = EcommercePermissions.Category.Delete;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryAppService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<PagedResultDto<CategoryDto>> SearchAsync(CategorySearchDto condition)
        {
            PagedResultDto<CategoryDto> listResultDto = new PagedResultDto<CategoryDto>();
            var queryable = await _categoryRepository.GetQueryableAsync();
            var listCategory = queryable.Where(x => string.IsNullOrEmpty(condition.Filter) || x.Name.Contains(condition.Filter));

            listResultDto.TotalCount = listCategory.Count();
            listCategory = listCategory.Skip(condition.SkipCount).Take(condition.MaxResultCount).OrderBy(condition.Sorting);
            listResultDto.Items = ObjectMapper.Map<List<Category>, List<CategoryDto>>(listCategory.ToList());

            return listResultDto;
        }
    }
}
