using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cowin.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Qualification { get; set; }

        public string Location { get; set; }

        public string State { get; set; }

        public int Pincode { get; set; }

        public string Password { get; set; }


    }
}
