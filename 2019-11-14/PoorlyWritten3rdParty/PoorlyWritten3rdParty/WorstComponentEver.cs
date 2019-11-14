using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoorlyWritten3rdParty
{
    public static class WorstComponentEver
    {
        public static Version GetVersionFromUser()
        {
            try
            {
                Console.WriteLine("Enter a version:");
                string versionString = Console.ReadLine();

                return new Version(versionString);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Version IncreaseBuildByOne(Version version)
        {
            return new Version(version.Major, version.Minor + 1, version.Build, version.Revision);
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number % 2 == 0)
            {
                HandleEvenNumber(number);
            }

            if (number == 7)
            {
                Thread.Sleep(10000000);
            }

            for (int i = 2; i < number + 1 / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void HandleEvenNumber(int number)
        {
            Thread.Sleep(1000000000);
        }

        public static void PrintCurrentTime()
        {
            ColorConsole.ConsoleWriter consoleWriter = new ColorConsole.ConsoleWriter();
            consoleWriter.WriteLine(DateTime.Now, ConsoleColor.Magenta);
        }

        public static void InsertItemAtBestLocation<T>(List<T> list, T item)
        {
            list.Insert(3, item);
        }
    }
}
