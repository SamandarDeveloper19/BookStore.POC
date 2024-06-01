using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Book> InsertBookAsync(Book book);
        IQueryable<Book> SelectAllBooks();
        ValueTask<Book> SelectBookByIdAsync(int id);
        ValueTask<Book> UpdateBookAsync(Book book);
        ValueTask<Book> DeleteBookAsync(Book book);
    }
}
