using System;

namespace MergeSort
{
    class Program
    {
        /// <summary>
        /// Driver Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // test input
            int[] arr = { 1, 4, 2, 3, 8, 5 };

            // Print original array
            Console.WriteLine("Input Array:");
            PrintArr(arr);

            // Sort array
            Sort(arr, 0, arr.Length - 1);

            // print sorted
            Console.WriteLine("\nArray Sorted:");
            PrintArr(arr);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Merge two subarrays of arr
        /// One is left half
        /// Other is right half
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two sub arrays
            int len1 = mid - left + 1;
            int len2 = right - mid;

            // Create temporary arrays and set their size
            int[] leftArr = new int[len1];
            int[] rightArr = new int[len2];

            // Copy the data of the sub arrays, to the temporary arrays
            for (int i = 0; i < len1; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (int i = 0; i < len2; i++)
            {
                rightArr[i] = arr[mid + 1 + i];
            }

            // Merge the temporary arrays into one

            // Create initial indexes of the two subarrays
            int counter1 = 0, counter2= 0;

            // Initial index of the merged 
            int mergeCounter = left;
            while (counter1 < len1 && counter2 < len2)
            {
                if (leftArr[counter1] <= rightArr[counter2])
                {
                    arr[mergeCounter] = leftArr[counter1];
                    counter1++;
                }
                else
                {
                    arr[mergeCounter] = rightArr[counter2];
                    counter2++;
                }
                mergeCounter++;
            }

            // copy remaining elements of left subarray
            while (counter1 < len1)
            {
                arr[mergeCounter] = leftArr[counter1];
                counter1++;
                mergeCounter++;
            }

            // copy remaining elements of right subarray
            while (counter2 < len2)
            {
                arr[mergeCounter] = rightArr[counter2];
                counter2++;
                mergeCounter++;
            }
        }

        /// <summary>
        /// Function that sorts both subarrays
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // create a midpoint
                int mid = (left + right) / 2;

                // sort first half
                Sort(arr, left, mid);

                // sort second half
                Sort(arr, mid + 1, right);

                // Merge the two halves together
                Merge(arr, left, mid, right);
            }
        }

        /// <summary>
        /// Function to print array
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
