using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Inventory
    {
        public EQ_Inventory()
        {
            this.EQ_Inventory_Locations = new List<EQ_Inventory_Locations>();
        }

        public System.Guid InventoryID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<double> MinLevel { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> InUseQuantity { get; set; }
        public Nullable<decimal> VNPriceTotal { get; set; }
        public Nullable<double> InOrderQuantity { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Inventory_Locations> EQ_Inventory_Locations { get; set; }
    }
}
