using System;

/// <summary>
/// Given an array of n elements, write a function to search a given element x in the array
/// Return the index
/// </summary>

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int[] test = { 1, 44, 22, 921, 424, 11 };
            int x = 11;

            // call linear search method
            Console.WriteLine("The index of x = {0}", LinearSearch(test, x));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Loop through array
        /// If array index = target, return that index
        /// If it cannot be found in array, return -1 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
