using System;

namespace HelloWorld
{
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