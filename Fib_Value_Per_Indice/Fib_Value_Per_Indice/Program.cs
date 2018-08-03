using System;


/// <summary>
/// Create method to find fibonacci sequence value
/// Create method to show fibonacci value per index based on user input
/// </summary>
namespace Fib_Value_Per_Indice
{
    class Program
    {
        static void Main(string[] args)
        {
            // user instructions
            Console.WriteLine("Please enter positive integer");
            string userInput = Console.ReadLine();
            Console.WriteLine("--------------");

            // check user input
            bool isInt = int.TryParse(userInput, out int num);
            if (isInt)
            {
                // negative value
                if (num < 0)
                {
                    Console.WriteLine("Please enter positive integer");
                }
                // correct input format
                else
                {
                    EachFib(num);
                }
            }
            // incorrect user input
            else
            {
                Console.WriteLine("Please enter a positive whole number");
            }

            Console.Read();
        }

        // method to find fib value
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

        // method to show fib value by indice
        private static void EachFib(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Index {0}: {1}", i, Fib(i));
            }
        } 
    }
}
