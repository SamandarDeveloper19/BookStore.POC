using BookStore.POC.Api.Models.Books;

namespace BookStore.POC.Api.Models.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
