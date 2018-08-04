using System;

/// <summary>
/// Print all possible permutations of a string
/// </summary>

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // test string
            string testString = "Perm";
            int start = 0;
            int end = testString.Length - 1;

            // call method
            Permute(testString, start, end);

            // keep console open
            Console.Read();
        }

        // Permute method
        private static void Permute(string str, int ind1, int ind2)
        {
            // If starting index = end index return the new string
            if (ind1 == ind2)
            {
                Console.WriteLine(str);
            }
            // If not swap their positions
            else
            {
                for (int i = ind1; i < str.Length; i++)
                {
                    str = Swap(str, ind1, i);
                    Permute(str, ind1 + 1, ind2);
                    str = Swap(str, ind1, i);
                }
            }
        }

        // Swap method
        private static string Swap(string str, int pos1, int pos2)
        {
            // turn string into char array, move positions around, return the new string
            char temp;
            char[] arr = str.ToCharArray();
            temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
            string newString = new string(arr);
            return newString;
        }
    }
}
