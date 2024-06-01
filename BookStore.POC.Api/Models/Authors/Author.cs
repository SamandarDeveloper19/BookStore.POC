using BookStore.POC.Api.Models.BookAuthors;

namespace BookStore.POC.Api.Models.Authors
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
