using System;
namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Please enter a valid number: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out _));
        }
    }
}