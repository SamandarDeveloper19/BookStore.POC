using BookStore.POC.Api.Brokers.Storages;
using BookStore.POC.Api.Models.Categories;

namespace BookStore.POC.Api.Services.Foundations.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IStorageBroker storageBroker;

        public CategoryService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Category> AddCategoryAsync(Category category) =>
            await this.storageBroker.InsertCategoryAsync(category);

        public IQueryable<Category> RetrieveAllCategories() =>
            this.storageBroker.SelectAllCategorys();

        public async ValueTask<Category> RetrieveCategoryByIdAsync(int id) =>
            await this.storageBroker.SelectCategoryByIdAsync(id);

        public async ValueTask<Category> ModifyCategoryAsync(Category category) =>
            await this.storageBroker.UpdateCategoryAsync(category);

        public async ValueTask<Category> RemoveCategoryAsync(int id)
        {
            Category category = await this.storageBroker.SelectCategoryByIdAsync(id);

            return await this.storageBroker.DeleteCategoryAsync(category);
        }
    }
}
