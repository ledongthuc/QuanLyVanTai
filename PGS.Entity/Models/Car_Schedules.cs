using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Car_Schedules
    {
        public System.Guid ScheduleID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string RequestPerson { get; set; }
        public Nullable<System.Guid> CarID { get; set; }
        public Nullable<System.Guid> DriverID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<double> DistanceUsed { get; set; }
        public Nullable<double> BenzinUsed { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Car_Drivers Car_Drivers { get; set; }
        public virtual Car Car { get; set; }
    }
}
