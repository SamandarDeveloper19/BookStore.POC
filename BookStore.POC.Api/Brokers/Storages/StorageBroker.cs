using BookStore.POC.Api.Models.BookAuthors;
using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;

namespace BookStore.POC.Api.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public StorageBroker()
        {
            this.Database.Migrate();
        }

        public async ValueTask<T> InsertAsync<T>(T @object)
        {
            using var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Added;
            await broker.SaveChangesAsync();

            return @object;
        }

        public IQueryable<T> SelectAll<T>() where T : class
        {
            using var broker = new StorageBroker();

            return broker.Set<T>();
        }

        public async ValueTask<T> SelectAsync<T>(params object[] objectsId) where T : class
        {
            using var broker = new StorageBroker();

            return await broker.FindAsync<T>(objectsId);
        }

        public async ValueTask<T> UpdateAsync<T>(T @object)
        {
            using var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Modified;
            await broker.SaveChangesAsync();

            return @object;
        }

        public async ValueTask<T> DeleteAsync<T>(T @object)
        {
            using var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Deleted;
            await broker.SaveChangesAsync();

            return @object;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(bookAuthor => new { bookAuthor.BookId, bookAuthor.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(bookAuthor => bookAuthor.Book)
                .WithMany(book => book.BookAuthors)
                .HasForeignKey(bookAuthor => bookAuthor.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(bookAuthor => bookAuthor.Author)
                .WithMany(author => author.BookAuthors)
                .HasForeignKey(bookAuthor => bookAuthor.AuthorId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = StoreBook.db";

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
