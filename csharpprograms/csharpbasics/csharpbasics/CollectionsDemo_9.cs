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
            foreach (var elem in arrayList)
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
    

    internal static void GenericCollections()
    {
            List<Product> productList = new List<Product>();
            Product prod1 = new Product(1, "Rice", "Organic", "ABC", 60);
            Product prod2 = new Product(2, "Oil", "Sun Flower", "PQR", 100);
            Product prod3 = new Product(3, "Dal", "Special Dal", "PQR", 110);
            productList.Add(prod1);
            productList.Add(prod2);
            productList.Add(prod3);

            Console.WriteLine("Generic Collections : list of items");
            int total = 0;
            foreach(var item in productList)
            {
                item.Info();
                total = total + item.price;
                Console.WriteLine("contains pqr " + item.supplier.Contains("PQR"));
            }

            Console.WriteLine("Total "+total);
        }
    }
    class Product
    {
        int code;
        string name;
        string desc;
        internal string supplier;
        internal int price;

        internal Product(int code,string name,string desc,string suppier,int price)
        {
            this.code = code;
            this.name = name;
            this.desc = desc;
            this.supplier = suppier;
            this.price = price;
        }

        internal void Info()
        {
            Console.WriteLine("Code : " + this.code + " Name : " + this.name + " Supplier " + this.supplier + " Price " + this.price);
        }
    }
}
