using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Request_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public Nullable<double> RequestedQuantity { get; set; }
        public Nullable<double> ApprovedQuantity { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Mat_Requests Mat_Requests { get; set; }
        public virtual Material Material { get; set; }
    }
}
