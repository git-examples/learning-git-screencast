using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            string line = Console.ReadLine();

            int x = int.Parse(line);

            Console.WriteLine("x * 4 = " + (x * 4)); // another bugs

            Console.WriteLine("Feature A");
            Console.WriteLine("Feature B");

            Console.WriteLine("Feature C");
            // Fix bug
            Console.WriteLine("Feature D");

            Console.WriteLine("Feature E");
            Console.WriteLine("Feature F");

            Console.ReadLine();
        }
    }
}
