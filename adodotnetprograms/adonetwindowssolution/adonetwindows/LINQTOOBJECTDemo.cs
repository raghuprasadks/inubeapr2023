using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class LINQTOOBJECTDemo
    {

        internal static void LiQNTOOBKECTTest()
        {
            IList<ProductStore> prodctList = new List<ProductStore>();
            var prod1 = new ProductStore();
            prod1.productName = "HP Laptop";
            prod1.productPrice = 60000;
            prodctList.Add(prod1);

            var prod2 = new ProductStore();
            prod2.productName = "DELL Laptop";
            prod2.productPrice = 62000;
            prodctList.Add(prod2);

            var prod3 = new ProductStore();
            prod3.productName = "DELL DeskTop";
            prod3.productPrice = 58000;
            prodctList.Add(prod3);

            Console.WriteLine("Query syntax");
            var result = from prod in prodctList
                         select prod;

            foreach(ProductStore store in prodctList)
            {
                Console.WriteLine(" Name : {0}, Price : {1}", store.productName, store.productPrice);
            }
        }
    }

    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }

    }
}
