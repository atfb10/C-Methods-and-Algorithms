using System;
using System.Text;

/// <summary>
/// Method that performs basic string compression using the counts of characters
/// Works on any characters. (mixed alpha-numeric symbol)
/// </summary>

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input 
            string test = "a$$aaaeeeeeBB%%%%%BBBzzqYYYpppom!!!!";

            // call method, pass in arg
            Console.WriteLine("Compressed string: {0}", CompressString(test));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to compress string using StringBuilder Class 
        /// Create a stringbuilder object and counter
        /// Loop through array of characters and increase counter IF next character is same as current
        /// IF string is at end OR next character is different, append the data and reset counter
        /// Return the new StringBuilder object
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string CompressString(string str)
        {
            StringBuilder compress = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                counter++;

                if (i + 1 >= str.Length || str[i] != str[i + 1] )
                {
                    compress.Append(str[i]);
                    compress.Append(counter);
                    counter = 0;
                }
            }
            return compress.Length < str.Length ? compress.ToString() : str;
        }
    }
}
