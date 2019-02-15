using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            var text = new Texts();
            
        }

        private static void UseOut()
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("failed");
            }
            int number;
            var result = int.TryParse("abc", out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
         static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("an expected error occrued");
            }
        }
    }
}
