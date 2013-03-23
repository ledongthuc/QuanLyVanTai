using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Material
    {
        public Material()
        {
            this.Mat_Input_Details = new List<Mat_Input_Details>();
            this.Mat_Order_Details = new List<Mat_Order_Details>();
            this.Mat_Repair_Details = new List<Mat_Repair_Details>();
            this.Mat_Request_Details = new List<Mat_Request_Details>();
        }

        public System.Guid MaterialID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> MatCatID { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<System.Guid> UnitID { get; set; }
        public Nullable<decimal> USPrice { get; set; }
        public Nullable<decimal> VNPrice { get; set; }
        public Nullable<System.DateTime> LastBoughtDate { get; set; }
        public string IMEI { get; set; }
        public string Origin { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual Mat_Categories Mat_Categories { get; set; }
        public virtual ICollection<Mat_Input_Details> Mat_Input_Details { get; set; }
        public virtual ICollection<Mat_Order_Details> Mat_Order_Details { get; set; }
        public virtual ICollection<Mat_Repair_Details> Mat_Repair_Details { get; set; }
        public virtual ICollection<Mat_Request_Details> Mat_Request_Details { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
