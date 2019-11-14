using PoorlyWritten3rdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReference
{
    class ObjectReference
    {
        static void Main(string[] args)
        {
            List<object> list = GetList();
            object newItem = new object();

            WorstComponentEver.InsertItemAtBestLocation(list, newItem);

            Console.ReadLine();
        }

        private static List<object> GetList()
        {
            return Enumerable.Range(1, 20).Select(_ => new object()).ToList();
        }
    }
}
