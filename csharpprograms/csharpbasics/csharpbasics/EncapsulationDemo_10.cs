using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class EncapsulationDemo_10
    {

        internal static void DemoEncapsulation()
        {
            Customer cust1 = new Customer();
            cust1.Code = 1;
            cust1.Name = "Kushal";
            Console.WriteLine("customer code : " + cust1.Code);
            // cust1.Zipcode
            cust1.Location = "Bengaluru";
            Console.WriteLine("customer location : " + cust1.Location);



        }
    }

    class Customer
    {

        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Location { get; set; }
        //internal int zipcode;

        public int Zipcode { get; set; }


    }
}
