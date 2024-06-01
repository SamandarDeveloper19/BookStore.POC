using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Services.Processings.BookAuthors
{
    public interface IBookAuthorProcessingService
    {
        ValueTask<List<BookAuthor>> SaveBookAuthorsAsync(List<BookAuthor> bookAuthors);
    }
}
