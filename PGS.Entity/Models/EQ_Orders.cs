using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Orders
    {
        public EQ_Orders()
        {
            this.EQ_Order_Details = new List<EQ_Order_Details>();
        }

        public System.Guid OrderID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.Guid> SupplierID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public string Priority { get; set; }
        public string Receiver { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeliveryLocation { get; set; }
        public string Pricing { get; set; }
        public string PaymentTerm { get; set; }
        public string Quality { get; set; }
        public string Warranty { get; set; }
        public string RegardingTo { get; set; }
        public string Notes { get; set; }
        public string PersonInCharge { get; set; }
        public string Status { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Order_Details> EQ_Order_Details { get; set; }
    }
}
