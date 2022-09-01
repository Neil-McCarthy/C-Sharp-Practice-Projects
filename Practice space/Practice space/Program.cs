using System;
using System.Collections.Generic;

namespace Practice_space
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACKS
            Stack<int> stack = new Stack<int>();
            for (int index = 0; index < 10; index++)
            {
                stack.Push(index);
                Console.WriteLine("The number at the top of the stack is " + stack.Peek());
                //top of the stack means the last entered
            }

            Console.ReadLine();
        }
    } 
}