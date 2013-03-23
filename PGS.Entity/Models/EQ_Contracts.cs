using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Contracts
    {
        public EQ_Contracts()
        {
            this.EQ_Contract_Details = new List<EQ_Contract_Details>();
        }

        public System.Guid ContractID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.Guid> SupplierID { get; set; }
        public Nullable<System.Guid> StoreID { get; set; }
        public Nullable<System.DateTime> SignedDate { get; set; }
        public string ContractPrice { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> LatestDeliveryDate { get; set; }
        public string PersonInCharge { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<EQ_Contract_Details> EQ_Contract_Details { get; set; }
    }
}
