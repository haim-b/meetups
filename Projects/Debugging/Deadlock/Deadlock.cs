using PoorlyWritten3rdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    class Deadlock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write prime numbers until:");

            int upperBound = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers until {upperBound}:");

            PrintPrimeNumbers(upperBound);
        }


        private static void PrintPrimeNumbers(int upperBound)
        {
            Parallel.For(2, upperBound + 1, PrintNumberIfPrime);
        }

        private static void PrintNumberIfPrime(int i)
        {
            if (WorstComponentEver.IsPrimeNumber(i))
            {
                PrintNumber(i);
            }
        }

        private static void PrintNumber(int i)
        {
            Console.WriteLine(i.ToString("N0"));
        }

    }
}
