using BookStore.POC.Api.Models.Books;
using BookStore.POC.Api.Services.Foundations.Books;

namespace BookStore.POC.Api.Services.Processings.Books
{
    public class BookProcessingService : IBookProcessingService
    {
        private readonly IBookService bookService;

        public BookProcessingService(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public async ValueTask<Book> AddBookAsync(Book book)
        {
            Book returnigBook = await this.bookService.RetrieveBookByIdAsync(book.Id);

            if (returnigBook == null)
            {
                await this.bookService.AddBookAsync(book);
            }

            return book;
        }
    }
}
