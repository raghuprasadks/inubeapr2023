using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depencyinjectiondemo
{
    class Employee
    {

        public Employee()
        {
            Address addr = new Address();
            this.Address = addr;
        }

        // constructor injection

        public Employee(Address address)
        {
            this.Address = address;
        }
        // method injection
        public void CreateAddress(Address address)
        {
            this.Address = address;
        }

        //property
        public int Id { get; set; }
        public string Name { get; set; }

        public string Dept { get; set; }

        public int Salary { get; set; }
        // property injection
        public Address Address { get; set; }
    }
}
