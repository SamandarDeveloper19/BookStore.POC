using BookStore.POC.Api.Brokers.Storages;
using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Services.Foundations.BookAuthors
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly IStorageBroker storageBroker;

        public BookAuthorService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<BookAuthor> AddBookAuthorAsync(BookAuthor bookAuthor) =>
            await this.storageBroker.InsertBookAuthorAsync(bookAuthor);

        public IQueryable<BookAuthor> RetrieveAllBookAuthors() =>
            this.storageBroker.SelectAllBookAuthors();

        public async ValueTask<BookAuthor> RetrieveBookAuthorByIdAsync(int id) =>
            await this.storageBroker.SelectBookAuthorByIdAsync(id);

        public async ValueTask<BookAuthor> ModifyBookAuthorAsync(BookAuthor bookAuthor) =>
            await this.storageBroker.UpdateBookAuthorAsync(bookAuthor);

        public async ValueTask<BookAuthor> RemoveBookAuthorAsync(int id)
        {
            BookAuthor bookAuthor = await this.storageBroker.SelectBookAuthorByIdAsync(id);

            return await this.storageBroker.DeleteBookAuthorAsync(bookAuthor);
        }
    }
}
