using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Services.Foundations.BookAuthors
{
    public interface IBookAuthorService
    {
        ValueTask<BookAuthor> AddBookAuthorAsync(BookAuthor bookAuthor);
        IQueryable<BookAuthor> RetrieveAllBookAuthors();
        ValueTask<BookAuthor> RetrieveBookAuthorByIdAsync(int id);
        ValueTask<BookAuthor> ModifyBookAuthorAsync(BookAuthor bookAuthor);
        ValueTask<BookAuthor> RemoveBookAuthorAsync(int id);
    }
}
