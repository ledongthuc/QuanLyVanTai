using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Requests
    {
        public EQ_Requests()
        {
            this.EQ_Request_Details = new List<EQ_Request_Details>();
        }

        public System.Guid RequestID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string ProcedureCode { get; set; }
        public string Priority { get; set; }
        public Nullable<System.Guid> EQCatID { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Request_Details> EQ_Request_Details { get; set; }
    }
}
