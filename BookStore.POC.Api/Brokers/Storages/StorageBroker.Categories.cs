using BookStore.POC.Api.Models.Categories;
using Microsoft.EntityFrameworkCore;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Category> Categories { get; set; }

        public async ValueTask<Category> InsertCategoryAsync(Category category) =>
            await InsertAsync(category);

        public IQueryable<Category> SelectAllCategorys() =>
            SelectAll<Category>();

        public async ValueTask<Category> SelectCategoryByIdAsync(int id) =>
            await SelectAsync<Category>(id);

        public async ValueTask<Category> UpdateCategoryAsync(Category category) =>
            await UpdateAsync(category);

        public async ValueTask<Category> DeleteCategoryAsync(Category category) =>
            await DeleteAsync(category);
    }
}
