using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class Loops_3
    {

        internal static void DemoWhileLoop()
        {
            Console.WriteLine("print 2's table");
            int start = 2;
            int end = 20;
            while (start <= end)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
