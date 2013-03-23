using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Categories
    {
        public EQ_Categories()
        {
            this.Equipments = new List<Equipment>();
        }

        public System.Guid EQCatID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
