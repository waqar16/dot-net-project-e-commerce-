//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projectmigration5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Product_id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int TotalPrice { get; set; }
    }
}
