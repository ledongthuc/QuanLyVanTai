using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Users = new List<User>();
        }

        public System.Guid DeptID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
