using System;

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

            return x + y;
        }
    }
}