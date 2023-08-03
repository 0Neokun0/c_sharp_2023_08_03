using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 50;
            grades[3] = 60;
            grades[4] = 100;
            Console.WriteLine("greades at index 0 is : {0}", grades[0]);

            Console.WriteLine("input your grades :");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("greades at index 0 is now : {0}", grades[0]);
            Console.ReadKey();

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 30, 50, 60, 100 };

            // thrid way of initializing an array
            int[] gradesOfMathStudentB = { 20, 30, 4, 5, 4, 5 };

            Console.WriteLine("Lengh of grandesOfMathStudent A: {0}", gradesOfMathStudentsA.Length);
            Console.ReadLine();

        }
    }
}