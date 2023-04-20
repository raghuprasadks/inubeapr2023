using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyinjectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objects are not dependent on each other");
            /** option 1
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "ravi";

            Address address1 = new Address();
            address1.AddressId = 1;
            address1.Street = "Dinne";
            **/

            Console.WriteLine("Address is dependent on Employee.. tight coupling");

            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "ravi";
            emp1.Address.AddressId = 1;
            emp1.Address.Street = "MG Road";

            Console.WriteLine("Constructor dependency injection");
            Address addr1 = new Address();
            addr1.AddressId = 1;
            addr1.Street = "M G Road";
            addr1.Location = "Bengaluru";

            Employee emp2 = new Employee(addr1);
            emp2.Dept = "IT Dept";
            Console.WriteLine("Property dependency injection");
            Employee emp3 = new Employee();
            emp3.Address = addr1;
            Console.WriteLine("Method dependency injection");
            Employee emp4 = new Employee();
            emp4.CreateAddress(addr1);

        }
    }
}
