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
    
    public partial class Mat_Repair_Details
    {
        public int RepairDetail_ID { get; set; }
        public Nullable<int> RepairID { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> RepairCost { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Mat_Repairs Mat_Repairs { get; set; }
        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
