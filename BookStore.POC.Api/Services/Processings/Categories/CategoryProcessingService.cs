using BookStore.POC.Api.Models.Categories;
using BookStore.POC.Api.Services.Foundations.Categories;

namespace BookStore.POC.Api.Services.Processings.Categories
{
    public class CategoryProcessingService : ICategoryProcessingService
    {
        private readonly ICategoryService categoryService;

        public CategoryProcessingService(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async ValueTask<Category> SaveCategoryAsync(Category category)
        {
            Category returningCategory =
                await this.categoryService.RetrieveCategoryByIdAsync(category.Id);

            if (returningCategory == null)
            {
                await this.categoryService.AddCategoryAsync(category);
            }

            return category;
        }
    }
}
