using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cowinnew.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required]
        //[MaxLength(10)]
        public long Mobile { get; set; }
        [Required]
        public string Email { get; set; }

        public string Sex { get; set; }

        public bool Qualification_UG { get; set; }

        public bool Qualification_PG { get; set; }

        public bool Qualification_OTH { get; set; }

        public string Location { get; set; }

        public string State { get; set; }

      //  [MaxLength(6)]
        public int Pincode { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
     }
}
