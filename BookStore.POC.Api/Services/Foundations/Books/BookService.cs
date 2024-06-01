using BookStore.POC.Api.Brokers.Storages;
using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Services.Foundations.Books
{
    public class BookService : IBookService
    {
        private readonly IStorageBroker storageBroker;

        public BookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Book> AddBookAsync(Book book) =>
            await this.storageBroker.InsertBookAsync(book);

        public IQueryable<Book> RetrieveAllBooks() =>
            this.storageBroker.SelectAllBooks();

        public async ValueTask<Book> RetrieveBookByIdAsync(int id) =>
            await this.storageBroker.SelectBookByIdAsync(id);

        public async ValueTask<Book> ModifyBookAsync(Book book) =>
            await this.storageBroker.UpdateBookAsync(book);

        public async ValueTask<Book> RemoveBookAsync(int id)
        {
            Book book = await this.storageBroker.SelectBookByIdAsync(id);

            return await this.storageBroker.DeleteBookAsync(book);
        }
    }
}
