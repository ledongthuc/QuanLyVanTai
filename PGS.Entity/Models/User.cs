using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class User
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }

        public System.Guid UserID { get; set; }
        public Nullable<System.Guid> DeptID { get; set; }
        public Nullable<System.Guid> EmployeeID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Position { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
