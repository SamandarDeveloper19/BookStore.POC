using BookStore.POC.Api.Models.BookAuthors;
using BookStore.POC.Api.Models.Books;
using BookStore.POC.Api.Models.Categories;
using BookStore.POC.Api.Services.Processings.Authors;
using BookStore.POC.Api.Services.Processings.BookAuthors;
using BookStore.POC.Api.Services.Processings.Books;
using BookStore.POC.Api.Services.Processings.Categories;

namespace BookStore.POC.Api.Services.Orchestrations
{
    public class BookOrchestrationService : IBookOrchestrationService
    {
        private readonly IBookProcessingService bookProcessingService;
        private readonly IAuthorProcessingService authorProcessingService;
        private readonly ICategoryProcessingService categoryProcessingService;
        private readonly IBookAuthorProcessingService bookAuthorProcessingService;

        public BookOrchestrationService(IBookProcessingService bookProcessingService,
                                        IAuthorProcessingService authorProcessingService,
                                        ICategoryProcessingService categoryProcessingService,
                                        IBookAuthorProcessingService bookAuthorProcessingService)
        {
            this.bookProcessingService = bookProcessingService;
            this.authorProcessingService = authorProcessingService;
            this.categoryProcessingService = categoryProcessingService;
            this.bookAuthorProcessingService = bookAuthorProcessingService;
        }

        public async ValueTask<Book> ProcessBookAsync(Book book)
        {
            await this.bookProcessingService.AddBookAsync(book);

            List<BookAuthor> authors = book.BookAuthors.ToList();
            await this.authorProcessingService.SaveAuthors(authors);
            await this.bookAuthorProcessingService.SaveBookAuthorsAsync(authors);

            Category category = book.Category;
            await this.categoryProcessingService.SaveCategoryAsync(category);

            return book;
        }
    }
}
