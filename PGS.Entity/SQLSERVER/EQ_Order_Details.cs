//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PGS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EQ_Order_Details
    {
        public int PODetail_ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> EquipmentID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> USPrice { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual EQ_Orders EQ_Orders { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
