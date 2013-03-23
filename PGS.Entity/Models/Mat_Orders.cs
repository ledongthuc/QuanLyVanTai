using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Orders
    {
        public Mat_Orders()
        {
            this.Mat_Inputs = new List<Mat_Inputs>();
            this.Mat_Order_Details = new List<Mat_Order_Details>();
        }

        public System.Guid OrderID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<System.Guid> SupplierID { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public string OrderReason { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeliveryLocation { get; set; }
        public string Receiver { get; set; }
        public string OtherInfo { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Mat_Inputs> Mat_Inputs { get; set; }
        public virtual ICollection<Mat_Order_Details> Mat_Order_Details { get; set; }
        public virtual Mat_Requests Mat_Requests { get; set; }
    }
}
