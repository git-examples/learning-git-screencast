using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    /// <summary>
    /// Class for Adding
    /// </summary>
    public class Adding
    {
        public int Calculate(int x, int y)
        {
            if (x >= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("x = " + x);

            return x + y;
        }
    }
}