using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Input_Others
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> InputID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public Nullable<System.Guid> ContractID { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
