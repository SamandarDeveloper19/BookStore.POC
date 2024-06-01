using BookStore.POC.Api.Models.BookAuthors;
using Microsoft.EntityFrameworkCore;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<BookAuthor> BookAuthors { get; set; }

        public async ValueTask<BookAuthor> InsertBookAuthorAsync(BookAuthor bookAuthor) =>
            await InsertAsync(bookAuthor);

        public IQueryable<BookAuthor> SelectAllBookAuthors() =>
            SelectAll<BookAuthor>();

        public async ValueTask<BookAuthor> SelectBookAuthorByIdAsync(int id) =>
            await SelectAsync<BookAuthor>(id);

        public async ValueTask<BookAuthor> UpdateBookAuthorAsync(BookAuthor bookAuthor) =>
            await UpdateAsync(bookAuthor);

        public async ValueTask<BookAuthor> DeleteBookAuthorAsync(BookAuthor bookAuthor) =>
            await DeleteAsync(bookAuthor);
    }
}
