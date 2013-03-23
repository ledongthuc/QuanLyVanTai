//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PGS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public int UserID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string UserPosition { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public Nullable<int> DeptID { get; set; }
        public string UserNotes { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
