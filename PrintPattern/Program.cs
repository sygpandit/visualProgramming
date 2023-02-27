using System;
namespace PrintPattern
{
    class Program
    {
        public void Program()
        {
            for (int i = 0; i <= 4; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();

        }
    }
}