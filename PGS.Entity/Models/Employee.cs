using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Car_Drivers = new List<Car_Drivers>();
            this.Users = new List<User>();
        }

        public System.Guid EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string BirthLocation { get; set; }
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
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Car_Drivers> Car_Drivers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
