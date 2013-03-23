using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Stores
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
