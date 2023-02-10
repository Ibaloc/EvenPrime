using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.Write("Enter an Integer: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(isPrimeOrEven(num));
            }
            catch { Console.WriteLine("Not Odd/Even!"); }
        }

        static string isPrimeOrEven (int? num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            } 
            else if(num % 3 == 0)
            {
                return "Odd";
            }
            else
                return "Not Even/Odd";

        }
    }
}
