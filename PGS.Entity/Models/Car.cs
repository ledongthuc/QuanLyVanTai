using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Car
    {
        public Car()
        {
            this.Car_Maintenances = new List<Car_Maintenances>();
            this.Car_Schedules = new List<Car_Schedules>();
        }

        public System.Guid CarID { get; set; }
        public string CarModel { get; set; }
        public string CarName { get; set; }
        public string CarNumber { get; set; }
        public string CarDescription { get; set; }
        public Nullable<double> CarNoms { get; set; }
        public Nullable<System.DateTime> BoughtDate { get; set; }
        public Nullable<double> KMRuns { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Car_Maintenances> Car_Maintenances { get; set; }
        public virtual ICollection<Car_Schedules> Car_Schedules { get; set; }
    }
}
