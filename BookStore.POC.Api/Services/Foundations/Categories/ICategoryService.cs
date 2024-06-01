using BookStore.POC.Api.Models.Categories;

namespace BookStore.POC.Api.Services.Foundations.Categories
{
    public interface ICategoryService
    {
        ValueTask<Category> AddCategoryAsync(Category category);
        IQueryable<Category> RetrieveAllCategories();
        ValueTask<Category> RetrieveCategoryByIdAsync(int id);
        ValueTask<Category> ModifyCategoryAsync(Category category);
        ValueTask<Category> RemoveCategoryAsync(int id);
    }
}
