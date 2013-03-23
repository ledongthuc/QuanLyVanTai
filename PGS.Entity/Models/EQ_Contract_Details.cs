using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Contract_Details
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ContractID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> RequestQuantity { get; set; }
        public Nullable<double> ContractQuantity { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Contracts EQ_Contracts { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
