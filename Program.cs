using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0 || num == 1)
            { Console.WriteLine(num + " is not a prime number"); }
            else
            {
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    { Console.WriteLine(num + " is not a Prime Number"); return; }
                }
                Console.WriteLine(num + " is a Prime Number");
            }
        }
    }
}
