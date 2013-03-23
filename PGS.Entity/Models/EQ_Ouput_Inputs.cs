using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class EQ_Ouput_Inputs
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> OutputID { get; set; }
        public Nullable<System.Guid> InputID { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
