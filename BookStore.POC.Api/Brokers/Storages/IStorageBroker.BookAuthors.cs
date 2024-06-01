using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<BookAuthor> InsertBookAuthorAsync(BookAuthor bookAuthor);
        IQueryable<BookAuthor> SelectAllBookAuthors();
        ValueTask<BookAuthor> SelectBookAuthorByIdAsync(int id);
        ValueTask<BookAuthor> UpdateBookAuthorAsync(BookAuthor bookAuthor);
        ValueTask<BookAuthor> DeleteBookAuthorAsync(BookAuthor bookAuthor);
    }
}
