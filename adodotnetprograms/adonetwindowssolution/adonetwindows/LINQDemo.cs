using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class LINQDemo
    {
        internal static void QuerySyntax()
        {
            IList<string> productList = new List<string>();
            productList.Add("HP Laptop");
            productList.Add("Lenovo Laptop");
            productList.Add("MAC Laptop");
            productList.Add("DELL Laptop");
            productList.Add("DELL Desktop");
            productList.Add("VIVO Mobile");
            Console.WriteLine("Query syntax");
            var result = from prod in productList
                         select prod;

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Contains");
            var filteredresult = from prod in productList
                                 where prod.Contains("Laptop")
                                 select prod;
            foreach (string str in filteredresult)
            {
                Console.WriteLine(str);
            }
        }

        internal static void MethodSyntax()
        {
            IList<string> productList = new List<string>()
            {
                "HP Laptop",
                "Lenovo Laptop",
                "MAC Laptop",
                "DELL Laptop",
                "DELL Desktop",
                "VIVO Mobile"
            };

            var result = productList.Where(p => p.Contains(""));
            Console.WriteLine("Method syntax");
            foreach (string prod in result)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
    
