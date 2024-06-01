using BookStore.POC.Api.Models.Authors;

namespace BookStore.POC.Api.Services.Foundations.Authors
{
    public interface IAuthorService
    {
        ValueTask<Author> AddAuthorAsync(Author author);
        IQueryable<Author> RetrieveAllAuthors();
        ValueTask<Author> RetrieveAuthorByIdAsync(int id);
        ValueTask<Author> ModifyAuthorAsync(Author author);
        ValueTask<Author> RemoveAuthorAsync(int id);
    }
}
