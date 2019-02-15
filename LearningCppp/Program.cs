
using System;
using LearningCppp.Math;


namespace LearningCppp
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine(result);

            var method = ShppingMethod.Express;
            Console.WriteLine((int)method);

            float price = 1234.1f;
            var sentense = "aasffasfsd asdfsdfsda";
            var words = sentense.Split(' ');
            
            string[] words2 = sentense.Split(' ');

            yay wow = new yay() { wow = 1 };

            Console.WriteLine(wow.wow);
            
        }
        public struct yay
        {
            public int wow;
        }
        public enum ShppingMethod
        {
            RegularAirMail = 1,
            RegisteredAireMail = 1,
            Express = 1
        }

    }
}
