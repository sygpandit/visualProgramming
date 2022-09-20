using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rem, rev = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}