using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class Calculator_1
    {
        public static void Add(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Sum  :" + result);
        }

        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

    }
}
