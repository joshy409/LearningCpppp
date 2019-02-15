using System;

namespace Classes
{
    public class Presentation {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("duplicated");
        }
    }
}
