using System;

/// <summary>
/// Allow user to enter number
/// Factorial is calculated if num is int and positive
/// </summary>
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // user enter integer
            Console.WriteLine("Please enter a positive integer to determine its n! value");
            string userInput = Console.ReadLine();

            // parse string to int
            bool isInt = int.TryParse(userInput, out int num);
            if (isInt)
            {
                // ensure int exceeds 0
                if (num < 0)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("Please Enter Positive Integer");
                }

                // call method and pass in parsed int
                else
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("N! of {0} = {1}", num, Factorial(num));
                }
            }
            else
            {
                Console.WriteLine("--------");
                Console.WriteLine("Please enter a positive, whole number");
            }

            // Keep console open
            Console.Read();
        }

        // method to calculate factorial
        private static int Factorial(int n)
        {
            int[] mem = new int[n+1];
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else if (mem[n] > 0)
            {
                return mem[n];
            }

            mem[n] = n * Factorial(n - 1);
            return mem[n];
        }
    }
}
