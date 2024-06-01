using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Services.Orchestrations
{
    public interface IBookOrchestrationService
    {
        ValueTask<Book> ProcessBookAsync(Book book);
    }
}
