using BookStore.POC.Api.Models.BookAuthors;
using BookStore.POC.Api.Services.Foundations.BookAuthors;

namespace BookStore.POC.Api.Services.Processings.BookAuthors
{
    public class BookAuthorProcessingService : IBookAuthorProcessingService
    {
        private readonly IBookAuthorService bookAuthorService;

        public BookAuthorProcessingService(IBookAuthorService bookAuthorService)
        {
            this.bookAuthorService = bookAuthorService;
        }

        public async ValueTask<List<BookAuthor>> SaveBookAuthorsAsync(List<BookAuthor> bookAuthors)
        {
            foreach (var bookAuthor in bookAuthors)
            {
                await this.bookAuthorService.AddBookAuthorAsync(bookAuthor);
            }

            return bookAuthors;
        }
    }
}
