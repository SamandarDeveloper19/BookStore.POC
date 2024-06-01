using BookStore.POC.Api.Models.Books;
using Microsoft.EntityFrameworkCore;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Book> Books { get; set; }

        public async ValueTask<Book> InsertBookAsync(Book book) =>
            await InsertAsync<Book>(book);

        public IQueryable<Book> SelectAllBooks() =>
            SelectAll<Book>();

        public async ValueTask<Book> SelectBookByIdAsync(int id) =>
            await SelectAsync<Book>(id);

        public async ValueTask<Book> UpdateBookAsync(Book book) =>
            await UpdateAsync<Book>(book);

        public async ValueTask<Book> DeleteBookAsync(Book book) =>
            await DeleteAsync<Book>(book);
    }
}
