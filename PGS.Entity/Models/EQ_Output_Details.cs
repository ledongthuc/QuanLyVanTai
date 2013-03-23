using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Output_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> OutputID { get; set; }
        public Nullable<System.Guid> InputID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Outputs EQ_Outputs { get; set; }
    }
}
