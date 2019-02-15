using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdafuction
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(5);
            //// args => expression
            //// number => number* number;
            //// () => ...
            //// ( x , y, z) => ...
            //Func<int, int> Square = number => number * number;
            //Console.WriteLine(Square(5));

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //Console.WriteLine(multiplier(10));


           


            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

 

        static int Square (int number)
        {
            return number * number;
        }
    }
}
