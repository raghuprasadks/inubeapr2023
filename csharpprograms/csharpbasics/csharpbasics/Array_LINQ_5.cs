using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class Array_LINQ_5
    {
        internal static void ArrayLinq()
        {
            int[] marks = {12,17,19,18,25,24 };
            Console.WriteLine("Maximum :: " + marks.Max());
            Console.WriteLine("Minimum :: " + marks.Min());
            Console.WriteLine("Sum :: " + marks.Sum());
            Console.WriteLine("Average :: " + marks.Average());
            Console.WriteLine("Original Array");
            foreach (var element in marks)
                Console.WriteLine(element);
            Array.Sort(marks);
            Console.WriteLine("Sorted Array");
            foreach (var element in marks)
                Console.WriteLine(element);
            Array.Reverse(marks);
            Console.WriteLine("Reversed Array");
            Array.ForEach<int>(marks, n => Console.WriteLine(n));
            Console.WriteLine(Array.BinarySearch(marks, 15));
        }
    }
}
