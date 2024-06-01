using BookStore.POC.Api.Models.Categories;

namespace BookStore.POC.Api.Services.Processings.Categories
{
    public interface ICategoryProcessingService
    {
        ValueTask<Category> SaveCategoryAsync(Category category);
    }
}
