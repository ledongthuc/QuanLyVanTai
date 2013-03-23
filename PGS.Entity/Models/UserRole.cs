using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class UserRole
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<System.Guid> RoleID { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
