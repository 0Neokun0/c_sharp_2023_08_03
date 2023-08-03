using System;
namespace String_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", name);
            }
            Console.ReadKey();
        }
    }
}