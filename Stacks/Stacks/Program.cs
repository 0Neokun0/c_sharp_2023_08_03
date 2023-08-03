using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using Push()
            // adding elements to the stack and printng the value on top of hte stack using peek
            // adding elements using Push()
            if (stack.Count < 0)
                stack.Pop();
            stack.Push(1);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            int myStackItem = stack.Pop();
            Console.WriteLine("popped item : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
        }
    }
}