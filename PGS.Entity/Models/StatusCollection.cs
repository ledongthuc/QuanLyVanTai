using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class StatusCollection
    {
        public System.Guid StatusID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string StatusGroup { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
