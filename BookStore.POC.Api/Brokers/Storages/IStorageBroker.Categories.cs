using BookStore.POC.Api.Models.Categories;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Category> InsertCategoryAsync(Category category);
        IQueryable<Category> SelectAllCategorys();
        ValueTask<Category> SelectCategoryByIdAsync(int id);
        ValueTask<Category> UpdateCategoryAsync(Category category);
        ValueTask<Category> DeleteCategoryAsync(Category category);
    }
}
