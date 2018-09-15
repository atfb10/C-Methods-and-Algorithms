using System;
using System.Text;

/// <summary>
/// Given string of lowercase characters from a-z, write a program
/// to print the characters of string in sorted order
/// </summary>

namespace AlphabeticallySortString
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "alphabet";

            // call method and print
            Console.WriteLine("Original string - {0}. Sorted string - {1}", test, SortString(test));

            // keep console open
            Console.Read();
        }

        private static string SortString(string str)
        {
            // create mutable stringbuilder object
            StringBuilder stringBld = new StringBuilder();

            // convert string to char array and sort
            char[] sorted = str.ToCharArray();
            Array.Sort(sorted);

            // append sorted characters to strinbulder object
            foreach (char c in sorted)
                stringBld.Append(c);

            // return the stringbuilder object as string
            return stringBld.ToString();
        }
    }
}
