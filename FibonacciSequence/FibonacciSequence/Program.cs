using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int input_int;
            Int32.TryParse(input, out input_int);
            Console.WriteLine("----------------");
            for (int i = 0; i < input_int; i++)
            {
                Console.WriteLine(fibonacci(i));
            }
        }


        static int fibonacci(int n)
        {
            if(n <= 1)
            {
                return n; 
            } else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }

        }
    }
}
