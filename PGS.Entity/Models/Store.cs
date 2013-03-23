using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Store
    {
        public Store()
        {
            this.Store_Locations = new List<Store_Locations>();
        }

        public System.Guid StoreID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string PersonInCharge { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Store_Locations> Store_Locations { get; set; }
    }
}
