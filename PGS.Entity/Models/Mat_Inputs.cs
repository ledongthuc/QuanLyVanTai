using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Mat_Inputs
    {
        public Mat_Inputs()
        {
            this.Mat_Input_Details = new List<Mat_Input_Details>();
        }

        public System.Guid InputID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public Nullable<System.Guid> SupplierID { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual ICollection<Mat_Input_Details> Mat_Input_Details { get; set; }
        public virtual Mat_Orders Mat_Orders { get; set; }
    }
}
