using PoorlyWritten3rdParty;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    static class Program
    {
        //static void Main()
        //{
        //    Console.ReadLine();
        //    Object o = new object();
        //    Object o2 = new object();

        //    Version version = WorstComponentEver.GetVersionFromUser();

        //    bool isLastBuildBeforeTests = WorstComponentEver.InceaseBuildByOne(version).GetBuildNumber().ShouldRunTestsOnBuild();

        //    Console.WriteLine("Next build will run tests: " + isLastBuildBeforeTests);

        //    Console.ReadLine();
        //}



















        static void Main()
        {
            //Console.WriteLine("Write prime numbers until:");

            //HandlePrimeNumbers();

            Console.ReadLine();

            WorstComponentEver.PrintCurrentTime();

            Console.ReadLine();
        }

        private static void HandlePrimeNumbers()
        {
            int upperBound = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers until {upperBound}:");

            Parallel.For(2, upperBound + 1, HandleNumber);
        }

        private static void HandleNumber(int i)
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

        private static int GetBuildNumber(this Version version)
        {
            return version.Build;
        }

        private static bool ShouldRunTestsOnBuild(this int buildNumber)
        {
            return buildNumber % 10 == 0;
        }
    }
}