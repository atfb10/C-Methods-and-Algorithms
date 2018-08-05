using System;

/// <summary>
/// Use binary search to find index of element in array of arbitrary length
/// </summary>

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // test args
            int[] testArr = { 2, 4, 5, 10, 40 };
            int start = 0;
            int end = testArr.Length - 1;
            int value = 4;

            // result
            int result = BinarySearch(testArr, start, end, value);

            // handle element in array
            if (result == -1)
            {
                Console.WriteLine("Element {0} is not in the array.", value);
            }
            else
            {
                Console.WriteLine("Element {0} is at index {1}.", value, result);
            }

            // keep console open
            Console.Read();
        }

        // binary search method
        private static int BinarySearch(int[] arr, int i, int j, int value)
        {
            // loop if start indece is less than or equal to end indece
            while (i <= j)
            {
                // split array in half
                int mid = i + (j - i) / 2;

                // see if element is at midpoint
                if (arr[mid] == value)
                {
                    return mid;
                }
                // see if element is larger than midpoint
                if (arr[mid] < value)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }

            // value not in array
            return -1;
        }
    }
}
