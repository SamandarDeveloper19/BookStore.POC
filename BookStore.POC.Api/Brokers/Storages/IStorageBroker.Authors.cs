using BookStore.POC.Api.Models.Authors;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Author> InsertAuthorAsync(Author author);
        IQueryable<Author> SelectAllAuthors();
        ValueTask<Author> SelectAuthorByIdAsync(int id);
        ValueTask<Author> UpdateAuthorAsync(Author author);
        ValueTask<Author> DeleteAuthorAsync(Author author);
    }
}
