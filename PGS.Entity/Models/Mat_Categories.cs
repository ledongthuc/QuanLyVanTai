using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Categories
    {
        public Mat_Categories()
        {
            this.Materials = new List<Material>();
        }

        public System.Guid MatCatID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}
