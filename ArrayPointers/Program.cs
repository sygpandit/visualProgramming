using System;
namespace ArrayPointers
{
    class ArrayPointers
    {
        static unsafe void Main(string[] args)
        {
            int[] num = { 1, 2 };
            fixed (int* p = num)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine((int)(p + i));
                }
            }

        }
    }
}