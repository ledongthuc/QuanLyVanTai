using System;
using System.Collections.Generic;

namespace PGS.Entity.Models
{
    public partial class Supplier
    {
        public System.Guid SupplierID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Nullable<System.Guid> CoTypeID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string AccountNo { get; set; }
        public string TaxNo { get; set; }
        public string ContactPerson { get; set; }
        public string ContactMobile { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.Guid> Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> Updator { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public virtual CoType CoType { get; set; }
    }
}
