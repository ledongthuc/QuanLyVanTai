using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Inventory_Locations
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> InventoryID { get; set; }
        public Nullable<System.Guid> LocationID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Inventory EQ_Inventory { get; set; }
    }
}
