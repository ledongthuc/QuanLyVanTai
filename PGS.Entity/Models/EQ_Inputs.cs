using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Inputs
    {
        public EQ_Inputs()
        {
            this.EQ_Input_Details = new List<EQ_Input_Details>();
        }

        public System.Guid InputID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Input_Details> EQ_Input_Details { get; set; }
    }
}
