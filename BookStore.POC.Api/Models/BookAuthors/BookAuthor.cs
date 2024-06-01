﻿using BookStore.POC.Api.Models.Authors;

namespace BookStore.POC.Api.Models.BookAuthors
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
