using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Services.Processings.Books
{
    public interface IBookProcessingService
    {
        ValueTask<Book> AddBookAsync(Book book);
    }
}
