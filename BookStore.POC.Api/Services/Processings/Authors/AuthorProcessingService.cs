using BookStore.POC.Api.Models.Authors;
using BookStore.POC.Api.Models.BookAuthors;
using BookStore.POC.Api.Services.Foundations.Authors;

namespace BookStore.POC.Api.Services.Processings.Authors
{
    public class AuthorProcessingService : IAuthorProcessingService
    {
        private readonly IAuthorService authorService;

        public AuthorProcessingService(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        public async ValueTask<List<BookAuthor>> SaveAuthors(List<BookAuthor> bookAuthors)
        {
            foreach (var bookAuthor in bookAuthors)
            {
                Author maybeAuthor =
                    await this.authorService.RetrieveAuthorByIdAsync(bookAuthor.AuthorId);

                if (maybeAuthor == null)
                {
                    await this.authorService.AddAuthorAsync(bookAuthor.Author);
                }
            }

            return bookAuthors;
        }
    }
}
