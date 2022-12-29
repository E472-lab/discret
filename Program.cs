using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter first number");
             a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
             b = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = a; i <= b; i++)
            {
                if (perfectnumber(i))
                {
                    Console.WriteLine("number:"+i);
                }
            }
            Console.ReadKey();
        }
        static bool perfectnumber(int number)
        {
            int digit = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    digit = digit + i;
            }
            if (digit == number)
            {
                return true;
            }
            return false;
        }

    }
}