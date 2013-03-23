using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Quotes
    {
        public EQ_Quotes()
        {
            this.EQ_Quote_Details = new List<EQ_Quote_Details>();
            this.EQ_Quote_Suppliers = new List<EQ_Quote_Suppliers>();
        }

        public System.Guid QuoteID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> QuoteDate { get; set; }
        public string Follower { get; set; }
        public Nullable<System.DateTime> AcceptedDate { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public string OtherIssues { get; set; }
        public string Status { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Quote_Details> EQ_Quote_Details { get; set; }
        public virtual ICollection<EQ_Quote_Suppliers> EQ_Quote_Suppliers { get; set; }
    }
}
