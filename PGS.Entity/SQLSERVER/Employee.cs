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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Car_Drivers = new HashSet<Car_Drivers>();
            this.Users = new HashSet<User>();
        }
    
        public int Employee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string BirthLocation { get; set; }
        public Nullable<int> DeptID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public byte[] Picture { get; set; }
        public string IDNo { get; set; }
        public Nullable<System.DateTime> IDIssuedDate { get; set; }
        public string IDIssuer { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> PassportIssuedDate { get; set; }
        public Nullable<System.DateTime> PassportExpiredDate { get; set; }
        public string PassportIssuer { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<Car_Drivers> Car_Drivers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
