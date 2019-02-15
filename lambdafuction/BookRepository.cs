using System.Collections.Generic;

namespace lambdafuction
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book> { new Book() { Title = "title 1", Price = 5 },
            new Book() { Title = "title 2", Price = 7 },
            new Book() { Title = "title 3", Price = 17 } };
        }
    }
}
