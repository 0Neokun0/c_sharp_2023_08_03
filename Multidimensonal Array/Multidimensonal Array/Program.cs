using System;
namespace Multidimensonal_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 }, // row 0
                { 4, 5, 6 }, // row 1
                { 7, 8, 9 }  // row 2
            };
            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.ReadKey();

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };

            string[,] array2DString = new string[3, 2] { 
                { "one", "two" }, 
                { "three", "four" }, 
                { "five", "six" } 
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;


            Console.WriteLine(" value is {0}", dimensions);
            Console.ReadKey();
        }
    }
}