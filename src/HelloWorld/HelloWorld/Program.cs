﻿using System;
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

            Console.WriteLine("x * 4 = " + (x * 4));

            Console.WriteLine("Feature A");
            Console.WriteLine("Feature B");

            Console.ReadLine();
        }
    }
}
