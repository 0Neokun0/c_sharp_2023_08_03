using System;
using System.Diagnostics.Metrics;

namespace Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }
            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }
            Console.ReadKey();
        }
    }
}