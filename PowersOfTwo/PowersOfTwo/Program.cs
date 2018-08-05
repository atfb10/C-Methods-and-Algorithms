using System;

/// <summary>
/// Return all powers of two for a user inputed value
/// </summary>

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Please input positive integer to find powers of two");
            string userInput = Console.ReadLine();

            // does nothing, just seperates output from input
            Console.WriteLine("-----");

            // parse if int
            bool isInt = int.TryParse(userInput, out int num);

            // print values
            if (isInt)
            {
                PowersOfTwo(num);
            }
            
            // re-instruct user
            else
            {
                Console.WriteLine("Please enter positive, whole number");
            }

            // keep console open
            Console.Read();
        }

        // method to return powers of two
        private static int PowersOfTwo(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("There are no powers of two for {0}", n);
                return 0;
            }
            else if (n == 1)
            {
                Console.WriteLine(n);
                return 1;
            }

            int prevNum = PowersOfTwo(n / 2);
            int currNum = prevNum * 2;
            Console.WriteLine(currNum);
            return currNum;
        }
    }
}
