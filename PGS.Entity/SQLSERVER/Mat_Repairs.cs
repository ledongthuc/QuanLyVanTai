//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PGS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mat_Repairs
    {
        public Mat_Repairs()
        {
            this.Mat_Repair_Details = new HashSet<Mat_Repair_Details>();
        }
    
        public int Repair_ID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<Mat_Repair_Details> Mat_Repair_Details { get; set; }
    }
}
