using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            this.EQ_Contract_Details = new List<EQ_Contract_Details>();
            this.EQ_Order_Details = new List<EQ_Order_Details>();
            this.EQ_Quote_Details = new List<EQ_Quote_Details>();
            this.EQ_Request_Details = new List<EQ_Request_Details>();
        }

        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public string ReferCode { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public Nullable<System.Guid> UnitID { get; set; }
        public Nullable<System.Guid> EQCatID { get; set; }
        public string Origin { get; set; }
        public Nullable<bool> IsCritical { get; set; }
        public Nullable<bool> IsReusable { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<int> EquipmentLevel { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual EQ_Categories EQ_Categories { get; set; }
        public virtual ICollection<EQ_Contract_Details> EQ_Contract_Details { get; set; }
        public virtual ICollection<EQ_Order_Details> EQ_Order_Details { get; set; }
        public virtual ICollection<EQ_Quote_Details> EQ_Quote_Details { get; set; }
        public virtual ICollection<EQ_Request_Details> EQ_Request_Details { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
