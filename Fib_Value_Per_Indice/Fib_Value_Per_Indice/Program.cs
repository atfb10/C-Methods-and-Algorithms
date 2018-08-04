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
            Console.WriteLine("Select number of indexes");
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
        private static int Fib(int n, int[] mem)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (mem[n] > 0)
            {
                return mem[n];
            }

            mem[n] = Fib(n - 1, mem) + Fib(n - 2, mem);
            return mem[n];
        }

        // method to show fib value by indice
        private static void EachFib(int n)
        {
            int[] mem = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Index {0}: {1}", i, Fib(i, mem));
            }
        } 
    }
}
