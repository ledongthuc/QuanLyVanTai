using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Unit
    {
        public Unit()
        {
            this.Equipments = new List<Equipment>();
            this.Materials = new List<Material>();
        }

        public System.Guid UnitID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UnitGroup { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}
