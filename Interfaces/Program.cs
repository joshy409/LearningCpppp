using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(0, 1);
            list.Add(1, 2);
            list.Add(2, 3);
            list.Add(3, 4);
            list.Add(4, 5);

            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine(list[i]);
                }
            }

        }
    }
}

