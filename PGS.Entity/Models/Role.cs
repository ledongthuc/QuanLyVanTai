using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Role
    {
        public Role()
        {
            this.UserRoles = new List<UserRole>();
        }

        public System.Guid RoleID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
