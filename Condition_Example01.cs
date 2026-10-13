using System;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number, and I'll square it:");

            string Strnumber = Console.ReadLine();
            int number = int.Parse(Strnumber);

            number *= number;
            Console.WriteLine("Result: " + number);

            Console.ReadKey();
        }
    }
}