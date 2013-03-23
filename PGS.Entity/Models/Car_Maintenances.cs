using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Car_Maintenances
    {
        public System.Guid MaintenanceID { get; set; }
        public string RequestPerson { get; set; }
        public string RequestReason { get; set; }
        public Nullable<System.Guid> CarID { get; set; }
        public Nullable<System.DateTime> MaintenanceBeginDate { get; set; }
        public Nullable<System.DateTime> MaintenanceEndDate { get; set; }
        public string MaintenanceType { get; set; }
        public Nullable<decimal> MaintenanceCost { get; set; }
        public string AfterMaintenance { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Car Car { get; set; }
    }
}
