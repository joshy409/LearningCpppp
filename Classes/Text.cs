using System;

namespace Classes
{
    public class Text : Presentation
    {
        public int FonsSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("added hyper link");
        }
    }
}
