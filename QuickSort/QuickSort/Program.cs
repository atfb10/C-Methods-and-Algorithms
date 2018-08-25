using System;

/// <summary>
/// C# Implementation of Quick Sort
/// </summary>
namespace QuickSort
{
    class Program
    {
        /// <summary>
        /// Driving method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // test input
            int[] arr = { 2, 4, 1, 3, 9 };

            // Display original array
            Console.WriteLine("Original Array:");
            PrintArr(arr);

            // sort array and print
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted Array:");
            PrintArr(arr);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Utility function to print array
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

        /// <summary>
        /// Take last element as pivot
        /// Set pivot to correct position in sorted array
        /// Place smaller elements to left of pivot
        /// Place larger elements to right of pivot
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private static int Part(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int index = start - 1;

            for (int i = start; i < end; i++)
            {
                // if element is less than pivot or equal to
                if (arr[i] <= pivot)
                {
                    index++;

                    // swap arr[index] and arr[i]
                    int tmp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = tmp;
                }
            }
            // swap arr[index+1] and arr of pivot
            int temp = arr[index + 1];
            arr[index + 1] = arr[end];
            arr[end] = temp;

            return index + 1;
        }

        /// <summary>
        /// Method that implements quicksort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                // p is partitioning index, arr[p] is at right place
                int p = Part(arr, start, end);

                // Recursively sort elements before partition and after partition
                Sort(arr, start, p - 1);
                Sort(arr, p + 1, end);
            }
        }
    }
}
