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
    
    public partial class EQ_Contracts
    {
        public int Contract_ID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> RequestID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public string FollowUpPerson { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual EQ_Requests EQ_Requests { get; set; }
        public virtual Store Store { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
