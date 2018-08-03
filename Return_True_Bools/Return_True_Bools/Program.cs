using System;

/// <summary>
/// Create method to accept array of booleans
/// If booleans are true
/// Array must be of an arbitrary length
/// </summary>
namespace Return_True_Bools
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create test array as argument
            bool[] testBool = { true, true, true, false, true, false, false, false, false, true, false };

            // call method and pass in test array
            TrueBool(testBool);

            // keep console open
            Console.Read();
        }

        // create method return only positive booleans
        private static void TrueBool(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
