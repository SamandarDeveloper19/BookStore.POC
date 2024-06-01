using BookStore.POC.Api.Models.Authors;
using Microsoft.EntityFrameworkCore;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Author> Authors { get; set; }

        public async ValueTask<Author> InsertAuthorAsync(Author author) =>
            await InsertAsync(author);

        public IQueryable<Author> SelectAllAuthors() =>
            SelectAll<Author>();

        public async ValueTask<Author> SelectAuthorByIdAsync(int id) =>
            await SelectAsync<Author>(id);

        public async ValueTask<Author> UpdateAuthorAsync(Author author) =>
            await UpdateAsync(author);

        public async ValueTask<Author> DeleteAuthorAsync(Author author) =>
            await DeleteAsync(author);
    }
}
