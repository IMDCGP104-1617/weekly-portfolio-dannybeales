using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();


            list.InsertBeginning(3);
            list.InsertAfter(5, 6);
            list.InsertBeginning(5);

        }
    }
}
