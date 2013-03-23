using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Outputs
    {
        public EQ_Outputs()
        {
            this.EQ_Output_Details = new List<EQ_Output_Details>();
        }

        public System.Guid OutputID { get; set; }
        public Nullable<System.Guid> SentStoreID { get; set; }
        public Nullable<System.Guid> ReceiveStoreID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Output_Details> EQ_Output_Details { get; set; }
    }
}
