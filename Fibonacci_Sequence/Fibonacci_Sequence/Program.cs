using System;


/// <summary>
/// Allow user to enter any positive int 
/// Program calculates fibonnaci sequnce
/// </summary>
namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Please enter positive integer to find fib sequence value");
            string userInput = Console.ReadLine();

            // parse input
            bool isInt = int.TryParse(userInput, out int num);

            // ensure parsing completed
            if (isInt)
            {
                // ensure user enters positive number
                if (num < 0)
                {
                    Console.WriteLine("Please enter a positive integer");
                }
                // return value
                else
                {
                    Console.WriteLine("Fibonacci sequnce of {0} = {1}", num, Fib(num));
                }
            }
            // not parseable
            else
            {
                Console.WriteLine("Please enter positive whole number");
            }

            // keep console open
            Console.Read();
        }

        // method to calc fib value
        private static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
