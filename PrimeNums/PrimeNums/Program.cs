using System;

/// <summary>
/// Print all prime numbers less than n
/// </summary>

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNumber = 20;

            Console.WriteLine("Prime numbers less than n:");
            PrimeNums(testNumber);

            Console.Read();
        }

        private static void PrimeNums(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i < n; i++)
                primes[i] = true;

            for (int i = 2; i*i <= n; i++)
            {
                if (primes[i] == true)
                {
                    for (int p = i*2; p <= n; p += i)
                    {
                        primes[p] = false;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
