using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Store_Locations
    {
        public System.Guid LocationID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Store Store { get; set; }
    }
}
