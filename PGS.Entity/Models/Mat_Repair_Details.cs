using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Repair_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> RepairID { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public Nullable<System.Guid> SupplierID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> RepairCost { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Mat_Repairs Mat_Repairs { get; set; }
        public virtual Material Material { get; set; }
    }
}
