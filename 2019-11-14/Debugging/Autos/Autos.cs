using PoorlyWritten3rdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    static class Autos
    {
        static void Main(string[] args)
        {
            Version version = WorstComponentEver.GetVersionFromUser();

            bool isLastBuildBeforeTests = WorstComponentEver.IncreaseBuildByOne(version).GetBuildNumber().ShouldRunTestsOnBuild();

            Console.WriteLine("Next build will run tests: " + isLastBuildBeforeTests);

            Console.ReadLine();
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
