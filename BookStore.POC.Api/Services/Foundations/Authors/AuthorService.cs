using BookStore.POC.Api.Brokers.Storages;
using BookStore.POC.Api.Models.Authors;

namespace BookStore.POC.Api.Services.Foundations.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly IStorageBroker storageBroker;

        public AuthorService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Author> AddAuthorAsync(Author author) =>
            await this.storageBroker.InsertAuthorAsync(author);

        public IQueryable<Author> RetrieveAllAuthors() =>
            this.storageBroker.SelectAllAuthors();

        public async ValueTask<Author> RetrieveAuthorByIdAsync(int id) =>
            await this.storageBroker.SelectAuthorByIdAsync(id);

        public async ValueTask<Author> ModifyAuthorAsync(Author author) =>
            await this.storageBroker.UpdateAuthorAsync(author);

        public async ValueTask<Author> RemoveAuthorAsync(int id)
        {
            Author author = await this.storageBroker.SelectAuthorByIdAsync(id);

            return await this.storageBroker.DeleteAuthorAsync(author);
        }
    }
}
