using System;

/// <summary>
/// Method to replace white space in a string and return new string
/// Much like a URL does
/// </summary>

namespace ReplaceWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string url = "www. google .com";

            // Call method, pass in ar
            Console.WriteLine("The original string {0} has been transformed to {1}", url, RemoveSpace(url));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Use regular expressions to find all white space 
        /// Replace white space with %20
        /// Return the new string
        /// </summary>
        /// <param name="str"></param>
        private static string RemoveSpace(string str)
        {
            string newString = System.Text.RegularExpressions.Regex.Replace(str, @"\s", "%20");
            return newString;
        }
    }
}
