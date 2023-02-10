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
            catch { Console.WriteLine("Not Prime/Odd/Even!"); }
        }

        static string isPrimeOrEven (int? num)
        {
            string result = "";
            if (num <= 1) result = "Not Prime";
            if (num == 2) result = "Prime";
            var limit = Math.Floor(Math.Sqrt(Convert.ToDouble(num)));
            for (int i = 2; i <= limit; ++i)
            {
                if (num % i == 0) { result = "Not Prime"; }
                else { result = "Prime"; }
            }

            if (String.IsNullOrWhiteSpace(result)) { result = "Prime"; }

            if (num % 2 == 0)
            {
                result = result + "/Even";
            }
            else
            {
                result = result + "/Odd";
            }

            return result;
        }
    }
}
