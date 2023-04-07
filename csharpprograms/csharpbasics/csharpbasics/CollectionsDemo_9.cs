using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class CollectionsDemo_9
    {

        internal static void NonGenericCollections()
        {
            Console.WriteLine("Non Generic Collections");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Suresh");
            arrayList.Add(true);
            arrayList.Add(null);

            Console.WriteLine("Element at 0th index " + arrayList[0]);
            string elemat1 = (string)arrayList[1];
            Console.WriteLine("Total elements  " + arrayList.Count);

            foreach(var elem in arrayList)
            {
                Console.WriteLine(elem);
            }

            arrayList.Insert(2, "C#");

            Console.WriteLine("Looping after insert");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
                
            }

            bool isFound = arrayList.Contains("Suresh");

            Console.WriteLine("is suresh found " + isFound);
        }
    }
}
