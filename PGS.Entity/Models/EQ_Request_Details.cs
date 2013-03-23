using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Request_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> InStockQuantity { get; set; }
        public Nullable<double> RequestedQuantity { get; set; }
        public Nullable<double> ApprovedQuantity { get; set; }
        public Nullable<double> NotYetOrderQuantity { get; set; }
        public Nullable<double> NotYetInputQuantity { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Requests EQ_Requests { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
