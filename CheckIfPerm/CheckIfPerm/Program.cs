using System;
using System.Text;

/// <summary>
/// Given two strings, write a method to decide if one is a permutation of the other
/// </summary>

namespace CheckIfPerm
{
    class Program
    {
        static void Main(string[] args)
        {
            // test inputs
            string test1 = "abc", test2 = "cab";

            // Call method and pass in arguments
            if (IsPerm(test1, test2))
            {
                Console.WriteLine("{0} is a permutation of {1}", test2, test1);
            }
            else
            {
                Console.WriteLine("{0} is NOT a permutation of {1}", test2, test1);
            }

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Take in two strings
        /// Check if same length, if not; cannot be permutation
        /// Return boolean result of equals method between two strings after using sort method
        /// </summary>
        private static bool IsPerm(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            return Sort(s1).Equals(Sort(s2));
        }

        /// <summary>
        /// Take in a string
        /// Convert string to char array
        /// Sort array alphabetically
        /// Create stringbuilder object to return new string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Sort(string s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);

            StringBuilder str = new StringBuilder();
            foreach (char c in a)
            {
                str.Append(c);
            }
            return str.ToString();
        }
    }
}
