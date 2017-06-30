using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    public class Adding
    {
        public int Calculate(int x, int y)
        {
            // It is to show consuming clients that they have error in their data
            if (x >= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("x = " + x);

            return x + y;
        }
    }
}