using System;

/// <summary>
/// Algorithm to determine if string has all unique characters
/// </summary>

namespace UniqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "abqienp";

            // call method, call in arg
            bool result = IsUnique(test);

            // if unique print first message, else print second
            if (result)
            {
                Console.WriteLine("Unique Characters Only");
            }
            else
            {
                Console.WriteLine("Duplicate Character(s) Exist");
            }

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Assume ASCII, must be less than or equal to 128 characters to all be unique
        /// Create a boolean array that sets each value that currently exists to true
        /// Loop through the string
        /// Assign variable index to hold value of index
        /// If that index's value exists (true) return false
        /// Else continue looping and assigning true until through the string
        /// If all get through whole string and all are unique, return true
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool IsUnique(string str)
        {
            if (str.Length > 128)
            {
                return false;
            }

            bool[] arr = new bool[128];

            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i];
                if (arr[index] == true)
                {
                    return false;
                }
                arr[index] = true;
            }
            return true;
        }
    }
}
