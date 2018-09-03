using System;
using System.Collections.Generic;

/// <summary>
/// Create a method to return the minimum value in a stack
/// </summary>

namespace MinValue_In_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            Stack<int> myStack = new Stack<int>();
            myStack.Push(33);
            myStack.Push(133);
            myStack.Push(3);
            myStack.Push(3333);
            myStack.Push(333);

            Console.WriteLine(MinInStack(myStack));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// pass in stack
        /// set initial value to top
        /// set min to top of stack 
        /// Loop through stack, comparing each value to min
        /// If num is less than min, set min to num
        /// Once through whole stack, return the min value
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        private static int MinInStack(Stack<int> stack)
        {
            int min = stack.Peek();

            foreach (int num in stack)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
