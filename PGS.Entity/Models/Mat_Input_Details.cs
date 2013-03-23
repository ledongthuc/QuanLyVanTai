using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Input_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> InputID { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> USPrice { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public string WarrantyTime { get; set; }
        public Nullable<System.Guid> ReceiveDeptID { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Mat_Inputs Mat_Inputs { get; set; }
        public virtual Material Material { get; set; }
    }
}
