using System;

// find the count of duplicate numbers that have one or more duplicates in the array

namespace Find_Num_Duplicates_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] test = { 1, 1, 5, 1, 4, 3};

            int numDups = CountDuplicates(test);

            Console.WriteLine(numDups);

            Console.Read();
        }

        /// <summary>
        /// Create counter to hold number duplicates
        /// Sort the array
        /// Loop through array
        /// Add if conditions are met
        /// Return counter
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int CountDuplicates(int[] arr)
        {
            int counter = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 && arr[i] == arr[i + 1])
                {
                    counter++;
                }

                if (i == arr.Length - 1 && arr[i] == arr[i - 1])
                {
                    counter++;
                }

                if (i != 0 && arr[i] == arr[i - 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
