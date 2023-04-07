using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class ArrayDemo_4
    {
        internal static void ArrayDemo()
        {
            int[] marks = { 15, 18, 9, 12, 24 };


            Console.WriteLine("length " + marks.Length);
            Console.WriteLine("Element at 0 th index " + marks[0]);
            Console.WriteLine("Update array element at 1");
            marks[1] = 20;
            Console.WriteLine("print elements: for loop");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("print elements: for each");
            foreach (var elem in marks)
            {
                Console.WriteLine(elem);
            }
        }
        internal static void ArrayMax()
        {
            int[] a = { 20, 13, 44, 78, 23, 18 };
            int max = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("MAXIMUM NO  "+max);

        }

        internal static void ArrayEvenArray()
        {
            int[] a = { 20, 13, 44, 78, 23, 18 };
            int count = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] %2==0)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int k = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] % 2 == 0)
                {
                    result[k] = a[i];
                    Console.WriteLine(result[k]);
                    k++;
                }
            }
        }
    }
}
