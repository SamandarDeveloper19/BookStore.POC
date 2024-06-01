using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Services.Foundations.Books
{
    public interface IBookService
    {
        ValueTask<Book> AddBookAsync(Book book);
        IQueryable<Book> RetrieveAllBooks();
        ValueTask<Book> RetrieveBookByIdAsync(int id);
        ValueTask<Book> ModifyBookAsync(Book book);
        ValueTask<Book> RemoveBookAsync(int id);
    }
}
