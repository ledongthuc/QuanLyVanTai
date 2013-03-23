using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Car_Drivers
    {
        public Car_Drivers()
        {
            this.Car_Schedules = new List<Car_Schedules>();
        }

        public System.Guid DriverID { get; set; }
        public Nullable<System.Guid> EmployeeID { get; set; }
        public Nullable<System.Guid> CarID { get; set; }
        public string DriverLicense { get; set; }
        public string DriverInfo { get; set; }
        public string DriverNotes { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Car_Schedules> Car_Schedules { get; set; }
    }
}
