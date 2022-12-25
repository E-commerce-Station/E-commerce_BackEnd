using Ecommerce.Categories.Dtos;
using Ecommerce.Permissions;
using System;
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
    }
}
