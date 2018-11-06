using System;

/// <summary>
/// Add a space between each character in a string
/// </summary>

namespace StringSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string name = "Adam";

            // call method
            string newName = SpaceChars(name);

            // print the string
            Console.WriteLine(newName);

            // keep console open
            Console.Read();
        }

        private static string SpaceChars(string str)
        {
            // initialize variables
            string temp = "";
            char[] arr = str.ToCharArray();

            // add space between chars and place result in temp
            for (int i = 0; i < arr.Length; i++)
                temp += arr[i] + " ";

            // return the new string
            return temp;
        }
    }
}
