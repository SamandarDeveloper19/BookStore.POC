using BookStore.POC.Api.Models.BookAuthors;
using BookStore.POC.Api.Models.Categories;

namespace BookStore.POC.Api.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
