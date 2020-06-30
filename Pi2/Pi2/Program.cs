using System;

namespace Pi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int input_int;
            Int32.TryParse(input, out input_int);
            double result = Math.Round(Math.PI, input_int);
            Console.WriteLine(result);
        }
    }
}
