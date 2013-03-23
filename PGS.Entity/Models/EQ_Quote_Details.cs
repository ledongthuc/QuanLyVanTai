using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Quote_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> QuoteID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Quotes EQ_Quotes { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
