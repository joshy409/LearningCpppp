using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Vehicle
    {
        private string _vim;
        //public Vehicle ()
        //{
        //    Console.WriteLine("vehicle");
        //}

        public Vehicle(string vim)
        {
            _vim = vim;
            Console.WriteLine("Vehicle. {0}", vim);
        }
    }
    public class Car : Vehicle
    {
        public Car(string vim)
            :base(vim)
        {
            Console.WriteLine("Car. {0}", vim);
        }

      
    }
}
