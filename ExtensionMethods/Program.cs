using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Linq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> {
                new Book() { Title = "title 1", Price = 5 },
                new Book() { Title = "title 2", Price = 9.99f },
                new Book() { Title = "title 3", Price = 17 } ,
                new Book() { Title = "title 4", Price = 7 },
                new Book() { Title = "title 4", Price = 9 }
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            ////LINQ Query Operators
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b;


            ////LINQ Extention Methods
            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b=> b.Title);


            //foreach (var book in cheapBooks) 
            //{
            //    Console.WriteLine(book);
            //} 

            var book = books.First(b => b.Title == "title 4");
            Console.WriteLine(book.Title + " " + book.Price);

            var maxPrice = books.Max(b => b.Price);
            var expensiveBook = books.Single(b => b.Price == books.Max(c => c.Price)).Title;
            var count = books.Count();
            Console.WriteLine(expensiveBook);
        }

    }
}
