using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class CoType
    {
        public CoType()
        {
            this.Suppliers = new List<Supplier>();
        }

        public System.Guid CoTypeID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
