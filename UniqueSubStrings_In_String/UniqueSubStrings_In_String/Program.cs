using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// For any given string, return all substrings
/// </summary>

namespace UniqueSubStrings_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "abacdf";

            // call methods and return result
            List<string> uniqueSubs = UniqueSubs(test);
            uniqueSubs = RemoveDups(uniqueSubs);
            PrintList(uniqueSubs);

            // keep console open
            Console.Read();
        }
        
        // utility method to print out list neatly
        private static void PrintList(List<string> list)
        {
            foreach (var substring in list)
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();
        }

        // method to remove duplicate substrings
        private static List<string> RemoveDups(List<string> list)
        {
            List<string> noDups = list.Distinct().ToList();
            return noDups;
        }

        /// <summary>
        /// Pass in string
        /// Create list to hold substrings
        /// loop through each character
        /// Within each character, add each character + its subsequent chars
        /// Return the list with all of the substrings (duplicates may be included at this point)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static List<string> UniqueSubs(string str)
        {
            List<string> uniques = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    uniques.Add(str.Substring(i, j - i + 1));
                }
            }

            return uniques;
        }
    }
}
