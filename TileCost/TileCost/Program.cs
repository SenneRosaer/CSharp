using System;

namespace TileCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a cost!");
            int input;
            Int32.TryParse(Console.ReadLine(), out input);

            int width = 500;
            int heighth = 200;
            Console.WriteLine($"Price is {width * heighth * input}");
        }
    }
}
