
using BookStore.POC.Api.Brokers.Storages;
using BookStore.POC.Api.Services.Foundations.Authors;
using BookStore.POC.Api.Services.Foundations.BookAuthors;
using BookStore.POC.Api.Services.Foundations.Books;
using BookStore.POC.Api.Services.Foundations.Categories;
using BookStore.POC.Api.Services.Orchestrations;
using BookStore.POC.Api.Services.Processings.Authors;
using BookStore.POC.Api.Services.Processings.BookAuthors;
using BookStore.POC.Api.Services.Processings.Books;
using BookStore.POC.Api.Services.Processings.Categories;

namespace BookStore.POC.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IStorageBroker, StorageBroker>();
            builder.Services.AddTransient<IBookService, BookService>();
            builder.Services.AddTransient<IAuthorService, AuthorService>();
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<IBookAuthorService, BookAuthorService>();
            builder.Services.AddTransient<IBookProcessingService, BookProcessingService>();
            builder.Services.AddTransient<IAuthorProcessingService, AuthorProcessingService>();
            builder.Services.AddTransient<ICategoryProcessingService, CategoryProcessingService>();
            builder.Services.AddTransient<IBookAuthorProcessingService, BookAuthorProcessingService>();
            builder.Services.AddTransient<IBookOrchestrationService, BookOrchestrationService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
