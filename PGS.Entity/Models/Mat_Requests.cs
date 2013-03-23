using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Requests
    {
        public Mat_Requests()
        {
            this.Mat_Orders = new List<Mat_Orders>();
            this.Mat_Request_Details = new List<Mat_Request_Details>();
        }

        public System.Guid RequestID { get; set; }
        public string ProdecureCode { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> SendDeptID { get; set; }
        public Nullable<System.Guid> ReceiveDeptID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string RequestForWhen { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Mat_Orders> Mat_Orders { get; set; }
        public virtual ICollection<Mat_Request_Details> Mat_Request_Details { get; set; }
    }
}
