using System;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int input_int;
            Int32.TryParse(input, out input_int);
            Console.WriteLine(Math.Round(Math.E, input_int));
        }
    }
}
