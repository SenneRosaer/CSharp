using System;
using System.Collections.Generic;
using System.Linq;

namespace Prime_Factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input;
            Int32.TryParse(Console.ReadLine(), out input);
            List<int> result = primeFactorization(input);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> primeFactorization(int number)
        {
            List<int> result = new List<int>();
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                }
            }
            return result;

        }
    }
}
