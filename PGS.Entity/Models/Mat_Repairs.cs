using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Repairs
    {
        public Mat_Repairs()
        {
            this.Mat_Repair_Details = new List<Mat_Repair_Details>();
        }

        public System.Guid RepairID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Mat_Repair_Details> Mat_Repair_Details { get; set; }
    }
}
