//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstApproach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class address
    {
        public int Id { get; set; }
        public string address1 { get; set; }
        public string location { get; set; }
        public int pincode { get; set; }
        public int EmployeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}