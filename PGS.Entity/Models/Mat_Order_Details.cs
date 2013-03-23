using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Order_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> USPrice { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Mat_Orders Mat_Orders { get; set; }
        public virtual Material Material { get; set; }
    }
}
