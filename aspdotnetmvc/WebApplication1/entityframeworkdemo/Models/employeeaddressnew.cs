//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityframeworkdemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employeeaddressnew
    {
        public int empaddid { get; set; }
        public int empcode { get; set; }
        public int addressid { get; set; }
    
        public virtual address address { get; set; }
        public virtual employee employee { get; set; }
    }
}
