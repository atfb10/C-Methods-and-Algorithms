using System;


/// <summary>
/// Take Array of arbitrary length
/// You can choose data type
/// Reverse an array 
/// print results onto console
/// </summary>
namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array for testing purposes
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e' };

            // call method and pass test array as arg
            Reverse(alphabet);

            // keep console open
            Console.Read();
        }

        // method to reverse string and print result
        private static void Reverse(char[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
