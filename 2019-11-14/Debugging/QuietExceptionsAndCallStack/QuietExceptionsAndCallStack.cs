using PoorlyWritten3rdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietExceptionsAndCallStack
{
    class QuietExceptionsAndCallStack
    {
        static void Main(string[] args)
        {
            Version version = WorstComponentEver.GetVersionFromUser();

            Console.WriteLine("The version is: " + version);

            Console.ReadLine();
        }
    }
}
