using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Services.Processings.Authors
{
    public interface IAuthorProcessingService
    {
        ValueTask<List<BookAuthor>> SaveAuthors(List<BookAuthor> authors);
    }
}
